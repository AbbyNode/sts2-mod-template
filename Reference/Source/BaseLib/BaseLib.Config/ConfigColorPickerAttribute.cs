using System;

namespace BaseLib.Config;

/// <summary>
/// <para>Displays this property as a color picker element, and sets some properties on the color picker.<br />
/// Not required for <see cref="T:Godot.Color" /> properties, if you want the default values.</para>
/// <para>Supported property types: <see cref="T:Godot.Color" /> and <see cref="T:System.String" /> (HTML color code).<br />
/// However, note that string is limited to standard 8-bit values, while Color supports a wider range if
/// <see cref="P:BaseLib.Config.ConfigColorPickerAttribute.EditIntensity" /> is true.</para>
/// <para>Beware: the default value for <see cref="T:Godot.Color" /> has alpha 0, so you likely want to set a default
/// value, especially if EditAlpha is false.</para>
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ConfigColorPickerAttribute : Attribute
{
	/// <summary>
	/// If true, allow the user to adjust the alpha (transparency) channel in the color picker popup.
	/// Defaults to true.
	/// </summary>
	public bool EditAlpha { get; set; } = true;

	/// <summary>
	/// <para>If true, allow the user to adjust the intensity slider, to support "overbright" or HDR-ish colors.<br />
	/// Disabled by default, since these colors are not supported for all use cases.</para>
	/// <para>Note: This is ignored unless the property type is <see cref="T:Godot.Color" /> as these above-maximum values
	/// cannot be stored as hex strings.</para>
	/// </summary>
	public bool EditIntensity { get; set; }
}
