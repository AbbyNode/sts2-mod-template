using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NSlotsContainer.cs")]
public class NSlotsContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _GuiInput;

		public static readonly StringName ProcessPanEvent;

		public static readonly StringName ProcessGuiFocus;

		public static readonly StringName ProcessScrollEvent;

		public new static readonly StringName _Process;

		public static readonly StringName OnToggleVisibility;

		public static readonly StringName Reset;

		public static readonly StringName SetEnabled;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName GetInitX;

		public static readonly StringName _whatsMoved;

		public static readonly StringName _dragStartPosition;

		public static readonly StringName _targetPosition;

		public static readonly StringName _isDragging;

		public static readonly StringName _tween;

		public static readonly StringName _epochSlots;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern float GetInitX { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _GuiInput(InputEvent inputEvent);

	public override extern void _Process(double delta);

	public extern void Reset();

	[AsyncStateMachine(typeof(_003CLerpToSlot_003Ed__20))]
	public extern Task LerpToSlot(float slotPositionX);

	public extern void SetEnabled(bool enabled);

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

	public extern NSlotsContainer();
}
