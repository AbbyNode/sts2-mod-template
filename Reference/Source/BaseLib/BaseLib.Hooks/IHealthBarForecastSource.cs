using System.Collections.Generic;

namespace BaseLib.Hooks;

/// <summary>
///     Produces one or more <see cref="T:BaseLib.Hooks.HealthBarForecastSegment" /> values for a creature's health bar overlay.
/// </summary>
/// <remarks>
///     Power models can implement this on the power type and are discovered from <see cref="P:MegaCrit.Sts2.Core.Entities.Creatures.Creature.Powers" />.
///     Additional sources can be registered with
///     <see cref="M:BaseLib.Hooks.HealthBarForecastRegistry.Register(System.String,System.String,BaseLib.Hooks.IHealthBarForecastSource)" />
///     or <see cref="M:BaseLib.Hooks.HealthBarForecastRegistry.RegisterForeign(System.String,System.String,System.Func{MegaCrit.Sts2.Core.Entities.Creatures.Creature,System.Collections.Generic.IEnumerable{System.Object}})" /> for cross-assembly duck-typed segments.
/// </remarks>
public interface IHealthBarForecastSource
{
	/// <summary>
	///     Returns segments to render for <paramref name="context" />; skip or yield empty when none apply.
	/// </summary>
	/// <param name="context">Creature and combat context for the bar being drawn.</param>
	IEnumerable<HealthBarForecastSegment> GetHealthBarForecastSegments(HealthBarForecastContext context);
}
