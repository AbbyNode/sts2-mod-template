using Godot;

namespace MegaCrit.Sts2.Core.Localization.Fonts;

public static class FontManager
{
	public static extern bool NeedsFontSubstitution(string language);

	public static extern Font? GetSubstituteFont(string language, FontType type);

	public static extern void ClearCache();
}
