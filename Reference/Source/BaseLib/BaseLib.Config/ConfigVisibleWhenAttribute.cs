using System;

namespace BaseLib.Config;

/// <summary>
/// No longer functional. Use ConfigVisibleIfAttribute instead.
/// </summary>
/// <param name="watchedPropertyName">The name of the property to watch (must be in the same ModConfig class).</param>
/// <param name="expectedValue">The value the watched property must have for this row to be visible.</param>
/// <param name="invert">If true, the row is visible when the value does NOT match.</param>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
[Obsolete("No longer functional. Use ConfigVisibleIfAttribute instead.", true)]
public class ConfigVisibleWhenAttribute(string watchedPropertyName, object expectedValue, bool invert = false) : Attribute
{
	public string WatchedPropertyName { get; } = watchedPropertyName;

	public object ExpectedValue { get; } = expectedValue;

	public bool Invert { get; } = invert;
}
