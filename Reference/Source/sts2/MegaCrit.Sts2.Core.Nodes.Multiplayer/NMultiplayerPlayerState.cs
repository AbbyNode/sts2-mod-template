using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerPlayerState.cs")]
public class NMultiplayerPlayerState : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnCreatureValueChanged;

		public static readonly StringName RefreshValues;

		public static readonly StringName UpdateHealthBarWidth;

		public static readonly StringName UpdateSelectionReticleWidth;

		public static readonly StringName OnEnergyChanged;

		public static readonly StringName OnStarsChanged;

		public static readonly StringName RefreshCombatValues;

		public static readonly StringName OnCreatureHovered;

		public static readonly StringName OnCreatureUnhovered;

		public static readonly StringName FlashPlayerReady;

		public static readonly StringName UpdateHighlightedState;

		public static readonly StringName BlockChanged;

		public static readonly StringName RefreshConnectedState;

		public static readonly StringName OnPlayerVotesCleared;

		public static readonly StringName OnPlayerEndTurnPing;

		public static readonly StringName FlashEndTurn;

		public static readonly StringName SetNextTweenTime;

		public static readonly StringName OnPlayerScreenChanged;

		public static readonly StringName TweenLocationIconAway;

		public static readonly StringName TweenLocationIconIn;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public static readonly StringName OnRelease;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Hitbox;

		public static readonly StringName _healthBar;

		public static readonly StringName _characterIcon;

		public static readonly StringName _nameplateLabel;

		public static readonly StringName _topContainer;

		public static readonly StringName _turnEndIndicator;

		public static readonly StringName _disconnectedIndicator;

		public static readonly StringName _networkProblemIndicator;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _locationIcon;

		public static readonly StringName _locationContainer;

		public static readonly StringName _energyContainer;

		public static readonly StringName _energyImage;

		public static readonly StringName _energyCount;

		public static readonly StringName _starContainer;

		public static readonly StringName _starCount;

		public static readonly StringName _cardContainer;

		public static readonly StringName _cardImage;

		public static readonly StringName _cardCount;

		public static readonly StringName _locationIconTween;

		public static readonly StringName _isMouseOver;

		public static readonly StringName _isCreatureHovered;

		public static readonly StringName _isHighlighted;

		public static readonly StringName _focusedWhileTargeting;

		public static readonly StringName _nextTweenTime;

		public static readonly StringName _currentLocationIcon;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NButton Hitbox
	{
		[CompilerGenerated]
		get;
	}

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public static extern NMultiplayerPlayerState Create(Player player);

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void OnCreatureHovered();

	public extern void OnCreatureUnhovered();

	public extern void FlashPlayerReady();

	protected extern void OnFocus(NButton _);

	protected extern void OnUnfocus(NButton _);

	protected extern void OnRelease(NButton _);

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

	public extern NMultiplayerPlayerState();
}
