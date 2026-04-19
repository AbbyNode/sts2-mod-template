using System;

namespace BaseLib.Config;

/// <summary>
/// Attempt to add hover tips to ALL config properties in this class. Use <see cref="T:BaseLib.Config.ConfigHoverTipAttribute" /> with
/// enabled=false to add exceptions. Still requires .hover.desc entries in your localization file, see <see cref="T:BaseLib.Config.ConfigHoverTipAttribute" />.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ConfigHoverTipsByDefaultAttribute : Attribute
{
}
