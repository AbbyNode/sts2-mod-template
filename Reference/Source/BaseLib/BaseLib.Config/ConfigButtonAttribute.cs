using System;
using BaseLib.Config.UI;

namespace BaseLib.Config;

/// <summary>
/// <para>Creates a clickable button from a method. Source code order is respected, so if the method is defined in between
/// two properties, the button will be in between their respective controls.</para>
/// <para>The method supports having any of these different arguments injected with any name, in any order (only the type is used):</para>
/// <br />
///   <b>ModConfig</b>: Injects the instance of your ModConfig (may be useful if the method is static).<br />
///   <b>NConfigButton</b>: Injects the instance of the button that was clicked.<br />
///   <b>NConfigOptionRow</b>: Injects the instance of the row the button belongs to (the node that handles its layout, hover tip, etc.).<br />
/// </summary>
/// <param name="buttonLabelKey">LocString key for the text on the button.</param>
[AttributeUsage(AttributeTargets.Method)]
public class ConfigButtonAttribute(string buttonLabelKey) : Attribute
{
	public string ButtonLabelKey { get; } = buttonLabelKey;

	/// <summary>The color to use for the button, as an HTML color code.</summary>
	public string Color { get; set; } = NConfigButton.DefaultColor;
}
