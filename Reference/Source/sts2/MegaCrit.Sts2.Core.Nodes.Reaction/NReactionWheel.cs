using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Reaction;

[ScriptPath("res://src/Core/Nodes/Reaction/NReactionWheel.cs")]
public class NReactionWheel : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Notification;

		public new static readonly StringName _Input;

		public static readonly StringName HideWheel;

		public static readonly StringName WarpMouseBackToOriginalPosition;

		public static readonly StringName React;

		public static readonly StringName MoveMarker;

		public static readonly StringName GetSelectedWedge;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _rightWedge;

		public static readonly StringName _downRightWedge;

		public static readonly StringName _downWedge;

		public static readonly StringName _downLeftWedge;

		public static readonly StringName _leftWedge;

		public static readonly StringName _upLeftWedge;

		public static readonly StringName _upWedge;

		public static readonly StringName _upRightWedge;

		public static readonly StringName _marker;

		public static readonly StringName _ignoreNextMouseInput;

		public static readonly StringName _centerPosition;

		public static readonly StringName _selectedWedge;

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

	public override extern void _Notification(int what);

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

	public extern NReactionWheel();
}
