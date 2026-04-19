using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Combat.History;

public class CombatHistory
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IEnumerable<CombatHistoryEntry> Entries { get; }

	public extern IEnumerable<CardPlayStartedEntry> CardPlaysStarted { get; }

	public extern IEnumerable<CardPlayFinishedEntry> CardPlaysFinished { get; }

	public extern event Action? Changed;

	public extern void Clear();

	public extern void CardPlayStarted(CombatState combatState, CardPlay cardPlay);

	public extern void CardPlayFinished(CombatState combatState, CardPlay cardPlay);

	public extern void CardAfflicted(CombatState combatState, CardModel card, AfflictionModel affliction);

	public extern void CardDiscarded(CombatState combatState, CardModel card);

	public extern void CardDrawn(CombatState combatState, CardModel card, bool fromHandDraw);

	public extern void CardExhausted(CombatState combatState, CardModel card);

	public extern void CardGenerated(CombatState combatState, CardModel card, bool generatedByPlayer);

	public extern void CreatureAttacked(CombatState combatState, Creature attacker, IReadOnlyList<DamageResult> damageResults);

	public extern void DamageReceived(CombatState combatState, Creature receiver, Creature? dealer, DamageResult result, CardModel? cardSource);

	public extern void BlockGained(CombatState combatState, Creature receiver, int amount, ValueProp props, CardPlay? cardPlay);

	public extern void EnergySpent(CombatState combatState, int amount, Player player);

	public extern void MonsterPerformedMove(CombatState combatState, MonsterModel monster, MoveState move, IEnumerable<Creature>? targets);

	public extern void OrbChanneled(CombatState combatState, OrbModel orb);

	public extern void PotionUsed(CombatState combatState, PotionModel potion, Creature? target);

	public extern void PowerReceived(CombatState combatState, PowerModel power, decimal amount, Creature? applier);

	public extern void StarsModified(CombatState combatState, int amount, Player player);

	public extern void Summoned(CombatState combatState, int amount, Player player);

	public extern CombatHistory();
}
