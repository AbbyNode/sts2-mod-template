using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards.Mocks;

public sealed class MockPowerCard : MockCardModel
{
	public override extern CardType Type { get; }

	public override extern TargetType TargetType { get; }

	public override extern MockCardModel MockBlock(int block);

	public extern MockPowerCard();
}
