using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Powers;

public abstract class TemporaryDexterityPower : PowerModel, ITemporaryPower
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public abstract AbstractModel OriginModel { get; }

	public extern PowerModel InternallyAppliedPower { get; }

	protected virtual extern bool IsPositive { get; }

	public override extern LocString Title { get; }

	public override extern LocString Description { get; }

	protected override extern string SmartDescriptionLocKey { get; }

	protected override extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern void IgnoreNextInstance();

	[AsyncStateMachine(typeof(_003CBeforeApplied_003Ed__22))]
	public override extern Task BeforeApplied(Creature target, decimal amount, Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterPowerAmountChanged_003Ed__23))]
	public override extern Task AfterPowerAmountChanged(PowerModel power, decimal amount, Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__24))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	protected extern TemporaryDexterityPower();
}
