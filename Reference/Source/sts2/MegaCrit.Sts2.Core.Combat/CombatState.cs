using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Singleton;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Combat;

public class CombatState : ICardScope
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IRunState RunState
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<Creature> Allies { get; }

	public extern IReadOnlyList<Creature> Enemies { get; }

	public extern IReadOnlyList<Creature> Creatures { get; }

	public extern IReadOnlyList<Creature> PlayerCreatures { get; }

	public extern IReadOnlyList<Player> Players { get; }

	public extern IReadOnlyList<ModifierModel> Modifiers
	{
		[CompilerGenerated]
		get;
	}

	public extern MultiplayerScalingModel? MultiplayerScalingModel
	{
		[CompilerGenerated]
		get;
	}

	public extern int RoundNumber
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CombatSide CurrentSide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern EncounterModel? Encounter { get; }

	public extern List<Creature> EscapedCreatures
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<Creature> CreaturesOnCurrentSide { get; }

	public extern IReadOnlyList<Creature> HittableEnemies { get; }

	public extern event Action<CombatState>? CreaturesChanged;

	public extern CombatState(EncounterModel? encounter = null, IRunState? runState = null, IReadOnlyList<ModifierModel>? modifiers = null, MultiplayerScalingModel? multiplayerScalingModel = null);

	public extern T CreateCard<T>(Player owner) where T : CardModel;

	public extern CardModel CreateCard(CardModel canonicalCard, Player owner);

	public extern CardModel CloneCard(CardModel mutableCard);

	public extern void AddCard(CardModel card, Player owner);

	public extern void RemoveCard(CardModel card);

	public extern bool ContainsCard(CardModel card);

	public extern void AddPlayer(Player player);

	public extern Creature CreateCreature(MonsterModel monster, CombatSide side, string? slot);

	public extern void CreatureEscaped(Creature creature);

	public extern void RemoveCreature(Creature creature, bool unattach = true);

	public extern bool ContainsCreature(Creature creature);

	public extern bool ContainsMonster<T>() where T : MonsterModel;

	public extern Creature? GetCreature(uint? combatId);

	[AsyncStateMachine(typeof(_003CGetCreatureAsync_003Ed__58))]
	public extern Task<Creature?> GetCreatureAsync(uint? combatId, double timeoutSec);

	public extern IReadOnlyList<Creature> GetCreaturesOnSide(CombatSide side);

	public extern IReadOnlyList<Creature> GetOpponentsOf(Creature creature);

	public extern IReadOnlyList<Creature> GetTeammatesOf(Creature creature);

	public extern Player? GetPlayer(ulong playerId);

	[IteratorStateMachine(typeof(_003CIterateHookListeners_003Ed__67))]
	public extern IEnumerable<AbstractModel> IterateHookListeners();

	public extern void SortEnemiesBySlotName();

	public extern void SetEnemyIndex(Creature creature, int index);

	public extern void AddCreature(Creature creature);
}
