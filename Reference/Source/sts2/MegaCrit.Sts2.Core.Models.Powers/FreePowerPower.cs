using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class FreePowerPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool TryModifyEnergyCostInCombat(CardModel card, decimal originalCost, out decimal modifiedCost);

	[AsyncStateMachine(typeof(_003CBeforeCardPlayed_003Ed__5))]
	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public extern FreePowerPower();
}
