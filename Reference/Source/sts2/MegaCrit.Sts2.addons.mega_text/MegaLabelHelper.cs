using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Text;

namespace MegaCrit.Sts2.addons.mega_text;

public static class MegaLabelHelper
{
	public static extern void AssertThemeFontOverride(Control control, StringName fontOverrideName);

	public static extern List<BbcodeObject> ParseBbcode(string bbcode);

	public static extern Vector2 EstimateTextSize(TextParagraph paragraph, List<BbcodeObject> objs, Font font, int fontSize, float maxWidth, float lineSpacing);

	public static extern bool IsTooBig(TextParagraph paragraph, List<BbcodeObject> objs, Font font, int fontSize, float lineSpacing, Vector2 rectSize, bool horizontallyBound, bool verticallyBound);

	public static extern Vector2 EstimateTextSize(TextParagraph paragraph, string text, Font font, int fontSize, float maxWidth, float lineSpacing, bool wrap = true);

	public static extern bool IsTooBig(TextParagraph paragraph, string text, Font font, int fontSize, float lineSpacing, bool wrap, Vector2 rectSize);
}
