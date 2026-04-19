using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Nodes.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Orbs;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCreature.cs")]
public class NCreature : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ConnectSpineAnimatorSignals;

		public static readonly StringName UpdateBounds;

		public static readonly StringName UpdateNavigation;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public static readonly StringName OnTargetingStarted;

		public static readonly StringName SetRemotePlayerFocused;

		public static readonly StringName HideHoverTips;

		public static readonly StringName SetAnimationTrigger;

		public static readonly StringName GetCurrentAnimationLength;

		public static readonly StringName GetCurrentAnimationTimeRemaining;

		public static readonly StringName ToggleIsInteractable;

		public static readonly StringName AnimDisableUi;

		public static readonly StringName AnimEnableUi;

		public static readonly StringName StartDeathAnim;

		public static readonly StringName StartReviveAnim;

		public static readonly StringName AnimTempRevive;

		public static readonly StringName ImmediatelySetIdle;

		public static readonly StringName AnimHideIntent;

		public static readonly StringName SetScaleAndHue;

		public static readonly StringName ScaleTo;

		public static readonly StringName SetDefaultScaleTo;

		public static readonly StringName OstyScaleToSize;

		public static readonly StringName AnimShake;

		public static readonly StringName DoScaleTween;

		public static readonly StringName SetOrbManagerPosition;

		public static readonly StringName GetTopOfHitbox;

		public static readonly StringName GetBottomOfHitbox;

		public static readonly StringName ShowMultiselectReticle;

		public static readonly StringName HideMultiselectReticle;

		public static readonly StringName ShowSingleSelectReticle;

		public static readonly StringName HideSingleSelectReticle;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Hitbox;

		public static readonly StringName OrbManager;

		public static readonly StringName IsInteractable;

		public static readonly StringName VfxSpawnPosition;

		public static readonly StringName Visuals;

		public static readonly StringName Body;

		public static readonly StringName IntentContainer;

		public static readonly StringName IsPlayingDeathAnimation;

		public static readonly StringName HasSpineAnimation;

		public static readonly StringName IsFocused;

		public static readonly StringName PlayerIntentHandler;

		public static readonly StringName _stateDisplay;

		public static readonly StringName _intentFadeTween;

		public static readonly StringName _shakeTween;

		public static readonly StringName _isRemotePlayerOrPet;

		public static readonly StringName _tempScale;

		public static readonly StringName _scaleTween;

		public static readonly StringName _isInMultiselect;

		public static readonly StringName _selectionReticle;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Task? DeathAnimationTask
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CancellationTokenSource DeathAnimCancelToken
	{
		[CompilerGenerated]
		get;
	}

	public extern Control Hitbox
	{
		[CompilerGenerated]
		get;
	}

	public extern NOrbManager? OrbManager
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsInteractable
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature Entity
	{
		[CompilerGenerated]
		get;
	}

	public extern Vector2 VfxSpawnPosition { get; }

	public extern NCreatureVisuals Visuals
	{
		[CompilerGenerated]
		get;
	}

	public extern Node2D Body { get; }

	public extern Control IntentContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsPlayingDeathAnimation { get; }

	public extern bool HasSpineAnimation { get; }

	public extern MegaSprite? SpineController { get; }

	public extern bool IsFocused
	{
		[CompilerGenerated]
		get;
	}

	public extern NMultiplayerPlayerIntentHandler? PlayerIntentHandler
	{
		[CompilerGenerated]
		get;
	}

	public extern T? GetSpecialNode<T>(string name) where T : Node;

	public static extern NCreature? Create(Creature entity);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void UpdateNavigation();

	public extern Task UpdateIntent(IEnumerable<Creature> targets);

	[AsyncStateMachine(typeof(_003CPerformIntent_003Ed__71))]
	public extern Task PerformIntent();

	[AsyncStateMachine(typeof(_003CRefreshIntents_003Ed__72))]
	public extern Task RefreshIntents();

	public extern void OnTargetingStarted();

	public extern void ShowHoverTips(IEnumerable<IHoverTip> hoverTips);

	public extern void SetRemotePlayerFocused(bool remotePlayerFocused);

	public extern void HideHoverTips();

	public extern void SetAnimationTrigger(string trigger);

	public extern float GetCurrentAnimationLength();

	public extern float GetCurrentAnimationTimeRemaining();

	public extern void ToggleIsInteractable(bool on);

	public extern Tween AnimDisableUi();

	public extern Tween AnimEnableUi();

	public extern float StartDeathAnim(bool shouldRemove);

	public extern void StartReviveAnim();

	public extern void AnimHideIntent(float delay = 0f);

	public extern void SetScaleAndHue(float scale, float hue);

	public extern void ScaleTo(float size, float duration);

	public extern void SetDefaultScaleTo(float size, float duration);

	public extern void OstyScaleToSize(float ostyHealth, float duration);

	public static extern Vector2 GetOstyOffsetFromPlayer(Creature osty);

	public extern void AnimShake();

	public extern Vector2 GetTopOfHitbox();

	public extern Vector2 GetBottomOfHitbox();

	public extern void TrackBlockStatus(Creature creature);

	public extern void ShowMultiselectReticle();

	public extern void HideMultiselectReticle();

	public extern void ShowSingleSelectReticle();

	public extern void HideSingleSelectReticle();

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

	public extern NCreature();
}
