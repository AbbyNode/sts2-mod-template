using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen;

[ScriptPath("res://src/Core/Nodes/Screens/FeedbackScreen/NSendFeedbackScreen.cs")]
public class NSendFeedbackScreen : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName Relocalize;

		public static readonly StringName OnDescriptionChanged;

		public static readonly StringName SetScreenshot;

		public static readonly StringName EmojiButtonSelected;

		public static readonly StringName SendButtonFocused;

		public static readonly StringName SendButtonUnfocused;

		public static readonly StringName Open;

		public static readonly StringName Close;

		public static readonly StringName ClearInput;

		public static readonly StringName SetSelectedEmoji;

		public static readonly StringName SendButtonSelected;

		public static readonly StringName WiggleCartoons1;

		public static readonly StringName WiggleCartoons2;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _backButton;

		public static readonly StringName _mainPanel;

		public static readonly StringName _descriptionInput;

		public static readonly StringName _emojiLabel;

		public static readonly StringName _sendButton;

		public static readonly StringName _sendLabel;

		public static readonly StringName _categoryDropdown;

		public static readonly StringName _successBackstop;

		public static readonly StringName _successPanel;

		public static readonly StringName _successLabel;

		public static readonly StringName _flower;

		public static readonly StringName _selectedEmoteButton;

		public static readonly StringName _screenshotBytes;

		public static readonly StringName _originalSuccessPosition;

		public static readonly StringName _lastClosedMsec;

		public static readonly StringName _descriptionText;

		public static readonly StringName _descriptionCaretLine;

		public static readonly StringName _descriptionCaretColumn;

		public static readonly StringName _wiggleTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control DefaultFocusedControl { get; }

	public static extern NSendFeedbackScreen? Create();

	public override extern void _Ready();

	public extern void Relocalize();

	public extern void SetScreenshot(Image screenshot);

	public extern void Open();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NSendFeedbackScreen();
}
