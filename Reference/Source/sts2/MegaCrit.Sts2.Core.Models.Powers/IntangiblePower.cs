using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class IntangiblePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern decimal ModifyHpLostAfterOsty(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task AfterModifyingHpLostAfterOsty();

	public override extern decimal ModifyDamageCap(Creature? target, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task AfterModifyingDamageAmount(CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__8))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern IntangiblePower();
}
