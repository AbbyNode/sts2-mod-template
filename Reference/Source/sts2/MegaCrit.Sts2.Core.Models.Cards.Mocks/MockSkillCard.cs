using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards.Mocks;

public sealed class MockSkillCard : MockCardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern CardType Type { get; }

	public override extern TargetType TargetType { get; }

	public override extern MockSkillCard MockBlock(int block);

	public extern MockSkillCard MockBlockCount(int blockCount);

	public extern MockSkillCard MockDraw(int cards);

	public extern MockSkillCard MockSummon(int summons);

	public extern MockSkillCard MockDiscard(int cards);

	public extern MockSkillCard MockForge(decimal forge);

	public extern MockSkillCard MockStarGain(decimal stars);

	public extern MockSkillCard MockPower<TPower>(int amount, TargetType targetType) where TPower : PowerModel;

	public extern MockSkillCard();
}
