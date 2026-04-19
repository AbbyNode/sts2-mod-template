using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class HardenedShellPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldScaleInMultiplayer { get; }

	public override extern int DisplayAmount { get; }

	public override extern decimal ModifyHpLostBeforeOstyLate(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task AfterModifyingHpLostBeforeOsty();

	public override extern Task AfterDamageReceived(PlayerChoiceContext choiceContext, Creature target, DamageResult result, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public extern HardenedShellPower();
}
