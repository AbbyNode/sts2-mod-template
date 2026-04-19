using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerPlayerStateContainer.cs")]
public class NMultiplayerPlayerStateContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Input;

		public static readonly StringName UpdateNavigation;

		public static readonly StringName LockNavigation;

		public static readonly StringName UnlockNavigation;

		public static readonly StringName UpdatePositionAfterOneFrame;

		public static readonly StringName UpdatePosition;

		public static readonly StringName AnimHide;

		public static readonly StringName AnimShow;

		public static readonly StringName ShowImmediately;

		public static readonly StringName HideImmediately;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName FirstPlayerState;

		public static readonly StringName _tween;

		public static readonly StringName _originalPosition;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NMultiplayerPlayerState? FirstPlayerState { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _Input(InputEvent inputEvent);

	public extern void Initialize(RunState runState);

	public extern void LockNavigation();

	public extern void UnlockNavigation();

	public extern void HighlightPlayer(Player player);

	public extern void UnhighlightPlayer(Player player);

	public extern void FlashPlayerReady(Player player);

	public extern void AnimHide();

	public extern void AnimShow();

	public extern void ShowImmediately();

	public extern void HideImmediately();

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

	public extern NMultiplayerPlayerStateContainer();
}
