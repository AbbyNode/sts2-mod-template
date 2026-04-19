using System;

namespace BaseLib.Config;

/// <summary>
/// Completely ignores this property. It will not be loaded or saved, and will not be shown for auto-generated UI.<br />
/// Intended for properties that aren't configuration options at all.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ConfigIgnoreAttribute : Attribute
{
}
