using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes;

[ScriptPath("res://src/Core/Nodes/NTransition.cs")]
public class NTransition : ColorRect
{
	public new class MethodName : ColorRect.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : ColorRect.PropertyName
	{
		public static readonly StringName InTransition;

		public static readonly StringName _initialGradientYPosition;

		public static readonly StringName _targetGradientYPosition;

		public static readonly StringName _gradientTransition;

		public static readonly StringName _simpleTransition;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : ColorRect.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool InTransition
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003CFadeOut_003Ed__15))]
	public extern Task FadeOut(float time = 0.8f, string transitionPath = "res://materials/transitions/fade_transition_mat.tres", CancellationToken? cancelToken = null);

	[AsyncStateMachine(typeof(_003CFadeIn_003Ed__16))]
	public extern Task FadeIn(float time = 0.8f, string transitionPath = "res://materials/transitions/fade_transition_mat.tres", CancellationToken? cancelToken = null);

	[AsyncStateMachine(typeof(_003CRoomFadeOut_003Ed__17))]
	public extern Task RoomFadeOut();

	[AsyncStateMachine(typeof(_003CRoomFadeIn_003Ed__18))]
	public extern Task RoomFadeIn(bool showTransition = true);

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

	public extern NTransition();
}
