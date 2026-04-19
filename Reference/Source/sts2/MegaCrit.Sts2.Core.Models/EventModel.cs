using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class EventModel : AbstractModel
{
	protected const string _initialPageKey = "INITIAL";

	protected CombatState? _combatStateForCombatLayout;

	public virtual extern Color ButtonColor { get; }

	public virtual extern bool IsDeterministic { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern string LocTable { get; }

	public extern LocString Title { get; }

	public virtual extern LocString InitialDescription { get; }

	public extern Player? Owner
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern bool IsShared { get; }

	public extern LocString? Description
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern EncounterModel? CanonicalEncounter { get; }

	public extern bool IsFinished { get; }

	public extern IReadOnlyList<EventOption> CurrentOptions { get; }

	public extern DynamicVarSet DynamicVars { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern Rng Rng
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern IEnumerable<LocString> GameInfoOptions { get; }

	public virtual extern EventLayoutType LayoutType { get; }

	public extern Control? Node
	{
		[CompilerGenerated]
		get;
	}

	public extern EventModel CanonicalInstance { get; }

	public extern bool HasVfx { get; }

	public static extern Vector2 VfxOffset { get; }

	public extern event Action<EventModel>? StateChanged;

	public extern event Action? EnteringEventCombat;

	public extern LocString? GetOptionTitle(string key);

	public extern LocString? GetOptionDescription(string key);

	[AsyncStateMachine(typeof(_003CBeginEvent_003Ed__30))]
	public extern Task BeginEvent(Player player, bool isPreFinished);

	protected virtual extern void SetInitialEventState(bool isPreFinished);

	protected virtual extern IReadOnlyList<EventOption> GenerateInitialOptionsWrapper();

	protected extern void ReplaceNullOptions(List<EventOption> options);

	protected abstract IReadOnlyList<EventOption> GenerateInitialOptions();

	protected extern void ClearCurrentOptions();

	public virtual extern bool IsAllowed(RunState runState);

	public extern PackedScene CreateScene();

	public extern void SetNode(Control node);

	public extern Texture2D CreateInitialPortrait();

	public extern PackedScene CreateBackgroundScene();

	public extern Node2D CreateVfx();

	public extern ICombatRoomVisuals CreateCombatRoomVisuals(IEnumerable<Player> players, ActModel act);

	public extern void GenerateInternalCombatState(IRunState runState);

	public extern EventModel ToMutable();

	protected override extern void DeepCloneFields();

	protected override extern void AfterCloned();

	public virtual extern void CalculateVars();

	protected extern LocString L10NLookup(string entryName);

	public virtual extern IEnumerable<string> GetAssetPaths(IRunState runState);

	public virtual extern void OnRoomEnter();

	public virtual extern Task Resume(AbstractRoom exitedRoom);

	protected extern void SetEventFinished(LocString description);

	protected virtual extern Task BeforeEventStarted();

	public virtual extern Task AfterEventStarted();

	protected virtual extern void OnEventFinished();

	public extern void EnsureCleanup();

	protected virtual extern void SetEventState(LocString description, IEnumerable<EventOption> eventOptions);

	protected extern void EnterCombatWithoutExitingEvent<T>(IReadOnlyList<Reward> extraRewards, bool shouldResumeAfterCombat) where T : EncounterModel;

	protected extern void EnterCombatWithoutExitingEvent(EncounterModel mutableEncounter, IReadOnlyList<Reward> extraRewards, bool shouldResumeAfterCombat);

	protected extern EventOption RelicOption<T>(Func<Task>? onChosen, string pageName = "INITIAL") where T : RelicModel;

	protected extern EventOption RelicOption(RelicModel relic, Func<Task>? onChosen, string pageName = "INITIAL");

	protected extern string InitialOptionKey(string optionName);

	protected extern EventModel();
}
