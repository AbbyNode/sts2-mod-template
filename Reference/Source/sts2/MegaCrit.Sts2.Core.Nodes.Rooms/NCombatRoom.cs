using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NCombatRoom.cs")]
public class NCombatRoom : Control, IScreenContext, IRoomWithProceedButton
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SubscribeToCombatEvents;

		public static readonly StringName AdjustCreatureScaleForAspectRatio;

		public static readonly StringName CreateAllyNodes;

		public static readonly StringName CreateEnemyNodes;

		public static readonly StringName RemoveCreatureNode;

		public static readonly StringName UpdateCreatureNavigation;

		public static readonly StringName OnActiveScreenUpdated;

		public static readonly StringName EnableControllerNavigation;

		public static readonly StringName RandomizeEnemyScalesAndHues;

		public static readonly StringName RadialBlur;

		public static readonly StringName SetWaitingForOtherPlayersOverlayVisible;

		public static readonly StringName OnProceedButtonPressed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Ui;

		public static readonly StringName SceneContainer;

		public static readonly StringName BgContainer;

		public static readonly StringName Background;

		public static readonly StringName ProceedButton;

		public static readonly StringName BackCombatVfxContainer;

		public static readonly StringName CombatVfxContainer;

		public static readonly StringName CreatedMsec;

		public static readonly StringName Mode;

		public static readonly StringName EncounterSlots;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _allyContainer;

		public static readonly StringName _enemyContainer;

		public static readonly StringName _radialBlur;

		public static readonly StringName _proceedButton;

		public static readonly StringName _waitingForOtherPlayersOverlay;

		public static readonly StringName _window;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NCombatRoom? Instance { get; }

	public extern NCombatUi Ui
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<NCreature> CreatureNodes { get; }

	public extern IEnumerable<NCreature> RemovingCreatureNodes { get; }

	public extern Control SceneContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NCombatBackground Background
	{
		[CompilerGenerated]
		get;
	}

	public extern NProceedButton ProceedButton { get; }

	public extern Node BackCombatVfxContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern Control CombatVfxContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern ulong CreatedMsec
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatRoomMode Mode
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Control DefaultFocusedControl { get; }

	public extern Control? FocusedControlFromTopBar { get; }

	public extern event Action? ProceedButtonPressed;

	public static extern NCombatRoom? Create(ICombatRoomVisuals visuals, CombatRoomMode mode);

	public override extern void _Ready();

	public static extern Rng GenerateBackgroundRngForCurrentPoint(IRunState state);

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void SetUpBackground(IRunState state);

	public static extern void PositionPlayersAndPets(List<NCreature> creatureNodes, float scaling, bool fullyCenterPlayers);

	public extern NCreature? GetCreatureNode(Creature? creature);

	public extern void RemoveCreatureNode(NCreature node);

	public extern void AddCreature(Creature creature);

	public extern void SetCreatureIsInteractable(Creature? creature, bool on);

	public extern void RestrictControllerNavigation(IEnumerable<Control> whitelist);

	public extern void EnableControllerNavigation();

	public extern void RadialBlur(VfxPosition vfxPosition = VfxPosition.Center);

	public extern void ShakeOstyIfDead(Player owner);

	public extern void PlaySplashVfx(Creature target, Color tint);

	public extern void SetWaitingForOtherPlayersOverlayVisible(bool visible);

	public extern void TransitionToActiveCombat(CombatRoom combatRoom);

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

	public extern NCombatRoom();
}
