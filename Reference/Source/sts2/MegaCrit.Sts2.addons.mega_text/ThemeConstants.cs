using Godot;

namespace MegaCrit.Sts2.addons.mega_text;

public static class ThemeConstants
{
	public static class Label
	{
		public static readonly StringName fontSize;

		public static readonly StringName font;

		public static readonly StringName lineSpacing;

		public static readonly StringName outlineSize;

		public static readonly StringName fontColor;

		public static readonly StringName fontOutlineColor;

		public static readonly StringName fontShadowColor;
	}

	public static class RichTextLabel
	{
		public static readonly StringName normalFont;

		public static readonly StringName boldFont;

		public static readonly StringName italicsFont;

		public static readonly StringName lineSpacing;

		public static readonly StringName normalFontSize;

		public static readonly StringName boldFontSize;

		public static readonly StringName boldItalicsFontSize;

		public static readonly StringName italicsFontSize;

		public static readonly StringName monoFontSize;

		public static readonly StringName[] allFontSizes;

		public static readonly StringName defaultColor;

		public static readonly StringName fontOutlineColor;

		public static readonly StringName fontShadowColor;
	}

	public static class Control
	{
		public static readonly StringName focus;
	}

	public static class MarginContainer
	{
		public static readonly StringName marginLeft;

		public static readonly StringName marginRight;

		public static readonly StringName marginTop;

		public static readonly StringName marginBottom;
	}

	public static class BoxContainer
	{
		public static readonly StringName separation;
	}

	public static class FlowContainer
	{
		public static readonly StringName hSeparation;

		public static readonly StringName vSeparation;
	}

	public static class TextEdit
	{
		public static readonly StringName font;
	}

	public static class LineEdit
	{
		public static readonly StringName font;
	}
}
