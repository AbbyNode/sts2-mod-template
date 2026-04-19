using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Credits;

[ScriptPath("res://src/Core/Nodes/Screens/Credits/NCreditsScreen.cs")]
public class NCreditsScreen : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName InitMegaCrit;

		public static readonly StringName InitComposer;

		public static readonly StringName InitAdditionalProgramming;

		public static readonly StringName InitAdditionalVfx;

		public static readonly StringName InitMarketingSupport;

		public static readonly StringName InitConsultants;

		public static readonly StringName InitVoices;

		public static readonly StringName InitLocalization;

		public static readonly StringName InitTwitchExtension;

		public static readonly StringName InitModdingSupport;

		public static readonly StringName InitPlaytesters;

		public static readonly StringName InitTrailer;

		public static readonly StringName InitFmod;

		public static readonly StringName InitSpine;

		public static readonly StringName InitGodot;

		public static readonly StringName InitExitMessage;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName CloseScreenDebug;

		public new static readonly StringName _GuiInput;

		public new static readonly StringName _Process;

		public static readonly StringName ProcessScrollEvent;

		public static readonly StringName ShuffleOneColumn;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _canClose;

		public static readonly StringName _exitingScreen;

		public static readonly StringName _tween;

		public static readonly StringName _screenContents;

		public static readonly StringName _backButton;

		public static readonly StringName _targetPosition;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control DefaultFocusedControl { get; }

	public static extern NCreditsScreen? Create();

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _GuiInput(InputEvent inputEvent);

	public override extern void _Process(double delta);

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

	public extern NCreditsScreen();
}
