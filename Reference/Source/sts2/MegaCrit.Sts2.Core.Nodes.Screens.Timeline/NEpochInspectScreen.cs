using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NEpochInspectScreen.cs")]
public class NEpochInspectScreen : NClickableControl, IScreenContext
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName HidePaginators;

		public static readonly StringName Close;

		public static readonly StringName UpdateShaderS;

		public static readonly StringName UpdateShaderV;

		public new static readonly StringName _Input;

		public static readonly StringName OnMouseReleased;

		public static readonly StringName SpeedUpTextAnimation;

		public static readonly StringName NextChapter;

		public static readonly StringName PrevChapter;

		public static readonly StringName RefreshChapterPaginators;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _closeButton;

		public static readonly StringName _portrait;

		public static readonly StringName _portraitFlash;

		public static readonly StringName _mask;

		public static readonly StringName _chains;

		public static readonly StringName _portraitHsv;

		public static readonly StringName _fancyText;

		public static readonly StringName _storyLabel;

		public static readonly StringName _chapterLabel;

		public static readonly StringName _closeLabel;

		public static readonly StringName _placeholderLabel;

		public static readonly StringName _nextChapterButton;

		public static readonly StringName _prevChapterButton;

		public static readonly StringName _unlockInfo;

		public static readonly StringName _hasStory;

		public static readonly StringName _wasRevealed;

		public static readonly StringName _prevChapterButtonOffsetX;

		public static readonly StringName _nextChapterButtonOffsetX;

		public static readonly StringName _maskOffsetX;

		public static readonly StringName _maskOffsetY;

		public static readonly StringName _closeButtonY;

		public static readonly StringName _unlockTween;

		public static readonly StringName _buttonTween;

		public static readonly StringName _tween;

		public static readonly StringName _textTween;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	public static readonly string lockedImagePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003COpen_003Ed__35))]
	public extern Task Open(NEpochSlot slot, EpochModel epoch, bool wasRevealed);

	public extern void Close();

	[AsyncStateMachine(typeof(_003CUnlockAnimation_003Ed__39))]
	public extern Task UnlockAnimation(EpochModel epoch);

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NEpochInspectScreen();
}
