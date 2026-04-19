using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen;

[ScriptPath("res://src/Core/Nodes/Screens/FeedbackScreen/NSendFeedbackFlower.cs")]
public class NSendFeedbackFlower : Control
{
	public enum State
	{
		None,
		Nodding,
		Anticipation,
		NoddingFast
	}

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetState;

		public static readonly StringName SetRandomPosition;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Cartoon;

		public static readonly StringName MyState;

		public static readonly StringName _tween;

		public static readonly StringName _originalPosition;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NSendFeedbackCartoon Cartoon
	{
		[CompilerGenerated]
		get;
	}

	public extern State MyState
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void SetState(State state);

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

	public extern NSendFeedbackFlower();
}
