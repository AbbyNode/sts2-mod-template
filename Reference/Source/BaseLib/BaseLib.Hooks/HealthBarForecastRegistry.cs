using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace BaseLib.Hooks;

/// <summary>
///     Aggregates health bar forecast segments from creature powers, registered sources, and optional foreign providers.
/// </summary>
/// <remarks>
///     Typed segments use <see cref="T:BaseLib.Hooks.HealthBarForecastSegment" />.
///     <see cref="M:BaseLib.Hooks.HealthBarForecastRegistry.RegisterForeign(System.String,System.String,System.Func{MegaCrit.Sts2.Core.Entities.Creatures.Creature,System.Collections.Generic.IEnumerable{System.Object}})" /> accepts objects with public instance properties:
///     <c>Amount</c> (<see cref="T:System.Int32" />), <c>Color</c> (<see cref="T:Godot.Color" />), <c>Direction</c> (enum or string
///     containing FromLeft/FromRight); optional <c>Order</c> (<see cref="T:System.Int32" />), <c>OverlayMaterial</c>
///     (<see cref="T:Godot.Material" />), <c>OverlaySelfModulate</c> (<see cref="T:Godot.Color" />?).
/// </remarks>
public static class HealthBarForecastRegistry
{
	/// <summary>
	///     A segment plus a monotonic key used to break ties when <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.Order" /> matches.
	/// </summary>
	/// <param name="Segment">Typed forecast data.</param>
	/// <param name="SequenceOrder">Stable ordering among sources (powers first, then registered providers).</param>
	internal readonly record struct RegisteredHealthBarForecastSegment(HealthBarForecastSegment Segment, long SequenceOrder);

	private readonly record struct ProviderEntry(string ModId, string SourceId, IHealthBarForecastSource? Source, Func<Creature, IEnumerable<object>>? ForeignProvider, long RegistrationOrder);

	private readonly record struct ForeignSegmentAccessors(Func<object, int> ReadAmount, Func<object, Color> ReadColor, Func<object, object?> ReadDirection, Func<object, int> ReadOrder, Func<object, Material?> ReadOverlayMaterial, Func<object, Color?> ReadOverlaySelfModulate);

	private static readonly Lock SyncRoot = new Lock();

	private static readonly Dictionary<(string ModId, string SourceId), ProviderEntry> Providers = new Dictionary<(string, string), ProviderEntry>();

	private static readonly ConcurrentDictionary<Type, ForeignSegmentAccessors?> ForeignSegmentAccessorCache = new ConcurrentDictionary<Type, ForeignSegmentAccessors?>();

	private static long _nextRegistrationOrder;

	/// <summary>
	///     Registers or replaces a forecast source implemented by <typeparamref name="TSource" />.
	/// </summary>
	/// <typeparam name="TSource">Concrete type with a parameterless constructor.</typeparam>
	/// <param name="modId">Owning mod identifier (for logging and stable keys).</param>
	/// <param name="sourceId">Optional unique id; defaults to the type's full name.</param>
	public static void Register<TSource>(string modId, string? sourceId = null) where TSource : IHealthBarForecastSource, new()
	{
		Register(modId, sourceId ?? typeof(TSource).FullName ?? typeof(TSource).Name, new TSource());
	}

	/// <summary>
	///     Registers or replaces a forecast source instance.
	/// </summary>
	/// <param name="modId">Owning mod identifier.</param>
	/// <param name="sourceId">Unique id for this source within the mod.</param>
	/// <param name="source">Provider instance.</param>
	public static void Register(string modId, string sourceId, IHealthBarForecastSource source)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(modId, "modId");
		ArgumentException.ThrowIfNullOrWhiteSpace(sourceId, "sourceId");
		ArgumentNullException.ThrowIfNull(source, "source");
		RegisterProvider(modId, sourceId, source, null);
	}

	/// <summary>
	///     Registers a provider that yields duck-typed segment objects (see class remarks).
	/// </summary>
	/// <param name="modId">Owning mod identifier.</param>
	/// <param name="sourceId">Unique id for this provider within the mod.</param>
	/// <param name="provider">Returns segment objects per creature; null entries are ignored.</param>
	public static void RegisterForeign(string modId, string sourceId, Func<Creature, IEnumerable<object>> provider)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(modId, "modId");
		ArgumentException.ThrowIfNullOrWhiteSpace(sourceId, "sourceId");
		ArgumentNullException.ThrowIfNull(provider, "provider");
		RegisterProvider(modId, sourceId, null, provider);
	}

	/// <summary>
	///     Removes a previously registered typed or foreign provider.
	/// </summary>
	/// <param name="modId">Mod identifier used at registration.</param>
	/// <param name="sourceId">Source id used at registration.</param>
	/// <returns><see langword="true" /> if an entry was removed.</returns>
	public static bool Unregister(string modId, string sourceId)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(modId, "modId");
		ArgumentException.ThrowIfNullOrWhiteSpace(sourceId, "sourceId");
		using (SyncRoot.EnterScope())
		{
			return Providers.Remove((modId, sourceId));
		}
	}

	/// <summary>
	///     Collects all applicable segments for <paramref name="creature" />, in registration order with sequence keys.
	/// </summary>
	/// <param name="creature">Creature whose bar is being evaluated.</param>
	internal static IReadOnlyList<RegisteredHealthBarForecastSegment> GetSegments(Creature creature)
	{
		ArgumentNullException.ThrowIfNull(creature, "creature");
		HealthBarForecastContext context = new HealthBarForecastContext(creature);
		List<RegisteredHealthBarForecastSegment> list = new List<RegisteredHealthBarForecastSegment>();
		long num = 0L;
		foreach (IHealthBarForecastSource item in creature.Powers.OfType<IHealthBarForecastSource>())
		{
			AppendTypedSegments(item, item.GetType().FullName ?? item.GetType().Name, context, num++, list, "creature power");
		}
		ProviderEntry[] array;
		using (SyncRoot.EnterScope())
		{
			array = Providers.Values.OrderBy((ProviderEntry entry) => entry.RegistrationOrder).ToArray();
		}
		ProviderEntry[] array2 = array;
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			ProviderEntry providerEntry = array2[num2];
			if (providerEntry.Source != null)
			{
				AppendTypedSegments(providerEntry.Source, providerEntry.SourceId, context, 1000000 + providerEntry.RegistrationOrder, list, "registered source (" + providerEntry.ModId + ")");
			}
			else if (providerEntry.ForeignProvider != null)
			{
				AppendForeignSegments(providerEntry.ForeignProvider, providerEntry.SourceId, creature, 1000000 + providerEntry.RegistrationOrder, list, providerEntry.ModId);
			}
		}
		return list;
	}

	private static void RegisterProvider(string modId, string sourceId, IHealthBarForecastSource? source, Func<Creature, IEnumerable<object>>? foreignProvider)
	{
		using (SyncRoot.EnterScope())
		{
			(string, string) key = (modId, sourceId);
			ProviderEntry value;
			long registrationOrder = (Providers.TryGetValue(key, out value) ? value.RegistrationOrder : _nextRegistrationOrder++);
			Providers[key] = new ProviderEntry(modId, sourceId, source, foreignProvider, registrationOrder);
		}
	}

	private static void AppendTypedSegments(IHealthBarForecastSource source, string sourceId, HealthBarForecastContext context, long sequenceOrder, List<RegisteredHealthBarForecastSegment> destination, string owner)
	{
		try
		{
			IEnumerable<HealthBarForecastSegment> healthBarForecastSegments = source.GetHealthBarForecastSegments(context);
			destination.AddRange(from segment in healthBarForecastSegments.Where(delegate(HealthBarForecastSegment segment)
				{
					HealthBarForecastSegment healthBarForecastSegment = segment;
					return healthBarForecastSegment.Amount > 0;
				})
				select new RegisteredHealthBarForecastSegment(segment, sequenceOrder));
		}
		catch (Exception value)
		{
			BaseLibMain.Logger.Warn($"[HealthBarForecast] Source '{sourceId}' from {owner} failed for creature '{context.Creature}': {value}", 1);
		}
	}

	private static void AppendForeignSegments(Func<Creature, IEnumerable<object>> provider, string sourceId, Creature creature, long sequenceOrder, List<RegisteredHealthBarForecastSegment> destination, string modId)
	{
		try
		{
			foreach (object item in provider(creature))
			{
				if (TryConvertForeignSegment(item, out var converted) && converted.Amount > 0)
				{
					destination.Add(new RegisteredHealthBarForecastSegment(converted, sequenceOrder));
				}
			}
		}
		catch (Exception value)
		{
			BaseLibMain.Logger.Warn($"[HealthBarForecast] Foreign source '{sourceId}' from mod '{modId}' failed for creature '{creature}': {value}", 1);
		}
	}

	private static bool TryConvertForeignSegment(object? segment, out HealthBarForecastSegment converted)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		converted = default(HealthBarForecastSegment);
		if (segment != null)
		{
			if (segment is HealthBarForecastSegment healthBarForecastSegment)
			{
				converted = healthBarForecastSegment;
				return true;
			}
			ForeignSegmentAccessors? orAdd = ForeignSegmentAccessorCache.GetOrAdd(segment.GetType(), CreateForeignSegmentAccessors);
			if (!orAdd.HasValue)
			{
				return false;
			}
			ForeignSegmentAccessors value = orAdd.Value;
			int amount = value.ReadAmount(segment);
			Color color = value.ReadColor(segment);
			if (!TryParseDirection(value.ReadDirection(segment), out var direction))
			{
				return false;
			}
			converted = new HealthBarForecastSegment(amount, color, direction, value.ReadOrder(segment), value.ReadOverlayMaterial(segment), value.ReadOverlaySelfModulate(segment));
			return true;
		}
		return false;
	}

	private static bool TryParseDirection(object? directionValue, out HealthBarForecastDirection direction)
	{
		direction = HealthBarForecastDirection.FromRight;
		if (directionValue != null)
		{
			if (directionValue is HealthBarForecastDirection healthBarForecastDirection)
			{
				direction = healthBarForecastDirection;
				return true;
			}
			string text = directionValue.ToString();
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			if (text.Contains("FromLeft", StringComparison.OrdinalIgnoreCase))
			{
				direction = HealthBarForecastDirection.FromLeft;
				return true;
			}
			if (!text.Contains("FromRight", StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			direction = HealthBarForecastDirection.FromRight;
			return true;
		}
		return false;
	}

	private static ForeignSegmentAccessors? CreateForeignSegmentAccessors(Type type)
	{
		PropertyInfo amount = type.GetProperty("Amount", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo color = type.GetProperty("Color", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo direction = type.GetProperty("Direction", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo order = type.GetProperty("Order", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo overlayMaterial = type.GetProperty("OverlayMaterial", BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo overlaySelfModulate = type.GetProperty("OverlaySelfModulate", BindingFlags.Instance | BindingFlags.Public);
		if (amount?.PropertyType != typeof(int) || color?.PropertyType != typeof(Color) || direction == null)
		{
			return null;
		}
		Func<object, Material> readOverlayMaterial = ((overlayMaterial?.PropertyType == typeof(Material)) ? ((Func<object, Material>)((object segment) => (Material)overlayMaterial.GetValue(segment))) : ((Func<object, Material>)((object _) => (Material?)null)));
		Func<object, Color?> readOverlaySelfModulate = ((overlaySelfModulate?.PropertyType == typeof(Color?)) ? ((Func<object, Color?>)((object segment) => (Color?)overlaySelfModulate.GetValue(segment))) : ((Func<object, Color?>)((object _) => (Color?)null)));
		return new ForeignSegmentAccessors((object segment) => (int)amount.GetValue(segment), (object segment) => (Color)color.GetValue(segment), (object segment) => direction.GetValue(segment), (order?.PropertyType == typeof(int)) ? ((Func<object, int>)((object segment) => (int)order.GetValue(segment))) : ((Func<object, int>)((object _) => 0)), readOverlayMaterial, readOverlaySelfModulate);
	}
}
