using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers.Mocks;

public sealed class MockModifyStarCostPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool AllowNegative { get; }

	public override extern bool TryModifyStarCost(CardModel card, decimal originalCost, out decimal modifiedCost);

	public extern MockModifyStarCostPower();
}
