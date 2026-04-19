using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards.Mocks;

public sealed class MockAttackCard : MockCardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern CardType Type { get; }

	public override extern TargetType TargetType { get; }

	public override extern MockAttackCard MockBlock(int block);

	public extern MockAttackCard MockDamage(decimal damage);

	public extern MockAttackCard MockOstyDamage(decimal damage);

	public extern MockAttackCard MockHitCount(int hitCount);

	public extern MockAttackCard MockFromOsty();

	public extern MockAttackCard MockTargetingType(TargetType targetingType);

	public extern MockAttackCard MockUnpoweredDamage();

	public extern MockAttackCard();
}
