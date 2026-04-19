using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NTargetingArrow.cs")]
public class NTargetingArrow : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public static readonly StringName UpdateArrowPosition;

		public static readonly StringName SetHighlightingOn;

		public static readonly StringName SetHighlightingOff;

		public static readonly StringName UpdateSegments;

		public static readonly StringName StartDrawingFrom;

		public static readonly StringName StopDrawing;

		public static readonly StringName UpdateDrawingTo;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName From;

		public static readonly StringName _fromPos;

		public static readonly StringName _fromControl;

		public static readonly StringName _toPosition;

		public static readonly StringName _segments;

		public static readonly StringName _arrowHead;

		public static readonly StringName _arrowHeadTween;

		public static readonly StringName _initialized;

		public static readonly StringName _followMouse;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public extern void SetHighlightingOn(bool isEnemy);

	public extern void SetHighlightingOff();

	public extern void StartDrawingFrom(Vector2 from, bool usingController);

	public extern void StartDrawingFrom(Control control, bool usingController);

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

	public extern NTargetingArrow();
}
