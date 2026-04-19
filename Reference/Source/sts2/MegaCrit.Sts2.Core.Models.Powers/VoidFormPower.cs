using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class VoidFormPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern Task BeforePowerAmountChanged(PowerModel power, decimal amount, Creature target, Creature? applier, CardModel? cardSource);

	public override extern Task BeforeApplied(Creature target, decimal amount, Creature? applier, CardModel? cardSource);

	public override extern bool TryModifyEnergyCostInCombat(CardModel card, decimal originalCost, out decimal modifiedCost);

	public override extern bool TryModifyStarCost(CardModel card, decimal originalCost, out decimal modifiedCost);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public extern VoidFormPower();
}
