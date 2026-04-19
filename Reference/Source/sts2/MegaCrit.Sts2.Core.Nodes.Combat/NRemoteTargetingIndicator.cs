using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NRemoteTargetingIndicator.cs")]
public class NRemoteTargetingIndicator : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public static readonly StringName StartDrawingFrom;

		public static readonly StringName StopDrawing;

		public static readonly StringName UpdateDrawingTo;

		public static readonly StringName DoTargetingCreatureTween;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName _fromPosition;

		public static readonly StringName _toPosition;

		public static readonly StringName _line;

		public static readonly StringName _lineBack;

		public static readonly StringName _tween;

		public static readonly StringName _isTargetingCreature;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Initialize(Player player);

	public override extern void _Process(double delta);

	public extern void StartDrawingFrom(Vector2 from);

	public extern void StopDrawing();

	public extern void UpdateDrawingTo(Vector2 position);

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

	public extern NRemoteTargetingIndicator();
}
