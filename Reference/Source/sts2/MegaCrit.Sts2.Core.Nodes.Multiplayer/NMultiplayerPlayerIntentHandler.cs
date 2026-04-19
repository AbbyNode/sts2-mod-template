using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerPlayerIntentHandler.cs")]
public class NMultiplayerPlayerIntentHandler : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnHitboxEntered;

		public static readonly StringName OnHitboxExited;

		public static readonly StringName OnHoverChanged;

		public static readonly StringName RefreshHoverDisplay;

		public static readonly StringName OnPeerInputStateChanged;

		public static readonly StringName OnPeerInputStateRemoved;

		public new static readonly StringName _Process;

		public static readonly StringName HideThinkyDots;

		public static readonly StringName RefreshHoverTips;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CardIntent;

		public static readonly StringName _cardIntent;

		public static readonly StringName _relicIntent;

		public static readonly StringName _potionIntent;

		public static readonly StringName _powerIntent;

		public static readonly StringName _hitbox;

		public static readonly StringName _targetingIndicator;

		public static readonly StringName _cardThinkyDots;

		public static readonly StringName _relicThinkyDots;

		public static readonly StringName _potionThinkyDots;

		public static readonly StringName _powerThinkyDots;

		public static readonly StringName _shouldShowHoverTip;

		public static readonly StringName _hoverTips;

		public static readonly StringName _isInPlayerChoice;

		public static readonly StringName _cardInPlayAwaitingPlayerChoice;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NMultiplayerCardIntent CardIntent { get; }

	public static extern NMultiplayerPlayerIntentHandler? Create(Player player);

	public override extern void _Ready();

	public override extern void _ExitTree();

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

	public extern NMultiplayerPlayerIntentHandler();
}
