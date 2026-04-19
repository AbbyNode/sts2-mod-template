using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NDropdownContainer.cs")]
public class NDropdownContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnVisibilityChange;

		public static readonly StringName RefreshLayout;

		public static readonly StringName IsScrollbarNeeded;

		public new static readonly StringName _Process;

		public static readonly StringName ProcessGuiFocus;

		public static readonly StringName UpdateScrollPosition;

		public static readonly StringName UpdateScrollbar;

		public static readonly StringName UpdatePositionBasedOnTrain;

		public new static readonly StringName _GuiInput;

		public static readonly StringName ProcessMouseEvent;

		public static readonly StringName ProcessScrollEvent;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _scrollbar;

		public static readonly StringName _scrollbarTrain;

		public static readonly StringName _dropdownItems;

		public static readonly StringName _maxHeight;

		public static readonly StringName _contentHeight;

		public static readonly StringName _startDragPos;

		public static readonly StringName _targetDragPos;

		public static readonly StringName _scrollLimitBottom;

		public static readonly StringName _isDragging;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void RefreshLayout();

	public override extern void _Process(double delta);

	public extern void UpdatePositionBasedOnTrain(float trainPosition);

	public override extern void _GuiInput(InputEvent inputEvent);

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

	public extern NDropdownContainer();
}
