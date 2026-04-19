using System;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat;

public class CombatStateTracker
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event Action<CombatState>? CombatStateChanged;

	public extern CombatStateTracker(CombatManager combatManager);

	extern ~CombatStateTracker();

	public extern void SetState(CombatState state);

	public extern void Subscribe(CardModel card);

	public extern void Unsubscribe(CardModel card);

	public extern void Subscribe(CardPile pile);

	public extern void Unsubscribe(CardPile pile);

	public extern void Subscribe(Creature creature);

	public extern void Unsubscribe(Creature creature);

	public extern void Subscribe(PlayerCombatState combatState);

	public extern void Unsubscribe(PlayerCombatState combatState);
}
