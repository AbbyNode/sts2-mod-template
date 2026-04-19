using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NDropdownScrollbar.cs")]
public class NDropdownScrollbar : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshTrainBounds;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName OnShow;

		public new static readonly StringName OnPress;

		public new static readonly StringName _Input;

		public new static readonly StringName _GuiInput;

		public static readonly StringName ClampTrain;

		public static readonly StringName SetTrainPositionFromPercentage;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _dropdownContainer;

		public static readonly StringName _train;

		public static readonly StringName hasControl;

		public static readonly StringName _startDragPos;

		public static readonly StringName _targetDragPos;

		public static readonly StringName _scrollLimitTop;

		public static readonly StringName _scrollLimitBottom;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	public bool hasControl;

	public override extern void _Ready();

	public extern void RefreshTrainBounds();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public override extern void _Input(InputEvent inputEvent);

	public override extern void _GuiInput(InputEvent inputEvent);

	public extern void SetTrainPositionFromPercentage(float percentage);

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

	public extern NDropdownScrollbar();
}
