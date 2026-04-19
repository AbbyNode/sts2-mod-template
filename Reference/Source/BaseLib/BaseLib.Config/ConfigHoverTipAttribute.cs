using System;

namespace BaseLib.Config;

/// <summary>
/// <para>Show a tooltip for this setting on hover. Requires a settings_ui.json localization file.
/// The names used are typically:</para>
/// YOURMOD-PROPERTY_NAME.hover.title (optional, if missing, no title will be shown)<br />
/// YOURMOD-PROPERTY_NAME.hover.desc (required)
/// </summary>
/// <param name="enabled">Enable hover tip for this property. Can be set to false in order to add exceptions for <see cref="T:BaseLib.Config.ConfigHoverTipsByDefaultAttribute" /></param>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class ConfigHoverTipAttribute(bool enabled = true) : Attribute
{
	public bool Enabled { get; } = enabled;
}
