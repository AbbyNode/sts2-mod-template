using Godot;

namespace MegaCrit.Sts2.Core.Localization.Fonts;

public static class FontControlUtils
{
	public static extern void ApplyLocaleFontSubstitution(this Control control, FontType fontType, StringName themeFontName);
}
