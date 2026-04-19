using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Commands;

public static class CreatureCmd
{
	[AsyncStateMachine(typeof(_003CAdd_003Ed__0<>))]
	public static extern Task<Creature> Add<T>(CombatState combatState, string? slotName = null) where T : MonsterModel;

	[AsyncStateMachine(typeof(_003CAdd_003Ed__1))]
	public static extern Task<Creature> Add(MonsterModel monster, CombatState combatState, CombatSide side = CombatSide.Enemy, string? slotName = null);

	[AsyncStateMachine(typeof(_003CAdd_003Ed__2))]
	public static extern Task Add(Creature creature);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__3))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, DamageVar damageVar, CardModel cardSource);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__4))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, decimal amount, ValueProp props, CardModel cardSource);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__5))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, IEnumerable<Creature> targets, DamageVar damageVar, Creature dealer);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__6))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, IEnumerable<Creature> targets, decimal amount, ValueProp props, Creature dealer);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__7))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, DamageVar damageVar, Creature dealer);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__8))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, decimal amount, ValueProp props, Creature dealer);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__9))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, DamageVar damageVar, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__10))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__11))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, IEnumerable<Creature> targets, DamageVar damageVar, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CDamage_003Ed__12))]
	public static extern Task<IEnumerable<DamageResult>> Damage(PlayerChoiceContext choiceContext, IEnumerable<Creature> targets, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CKill_003Ed__13))]
	public static extern Task Kill(Creature creature, bool force = false);

	[AsyncStateMachine(typeof(_003CKill_003Ed__14))]
	public static extern Task Kill(IReadOnlyCollection<Creature> creatures, bool force = false);

	public static extern Task Escape(Creature creature, bool removeCreatureNode = true);

	[AsyncStateMachine(typeof(_003CGainBlock_003Ed__17))]
	public static extern Task<decimal> GainBlock(Creature creature, BlockVar blockVar, CardPlay? cardPlay, bool fast = false);

	[AsyncStateMachine(typeof(_003CGainBlock_003Ed__18))]
	public static extern Task<decimal> GainBlock(Creature creature, decimal amount, ValueProp props, CardPlay? cardPlay, bool fast = false);

	[AsyncStateMachine(typeof(_003CLoseBlock_003Ed__19))]
	public static extern Task LoseBlock(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CHeal_003Ed__20))]
	public static extern Task Heal(Creature creature, decimal amount, bool playAnim = true);

	[AsyncStateMachine(typeof(_003CSetCurrentHp_003Ed__21))]
	public static extern Task SetCurrentHp(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CGainMaxHp_003Ed__22))]
	public static extern Task GainMaxHp(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CLoseMaxHp_003Ed__23))]
	public static extern Task LoseMaxHp(PlayerChoiceContext choiceContext, Creature creature, decimal amount, bool isFromCard);

	[AsyncStateMachine(typeof(_003CSetMaxHp_003Ed__24))]
	public static extern Task<decimal> SetMaxHp(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CSetMaxAndCurrentHp_003Ed__25))]
	public static extern Task SetMaxAndCurrentHp(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CStun_003Ed__26))]
	public static extern Task Stun(Creature creature, string? nextMoveId = null);

	public static extern Task Stun(Creature creature, Func<IReadOnlyList<Creature>, Task> stunMove, string? nextMoveId = null);

	[AsyncStateMachine(typeof(_003CTriggerAnim_003Ed__28))]
	public static extern Task TriggerAnim(Creature creature, string triggerName, float waitTime);
}
