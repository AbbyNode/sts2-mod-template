namespace MegaCrit.Sts2.Core.Models.Powers;

public class ShacklingPotionPower : TemporaryStrengthPower
{
	public override extern AbstractModel OriginModel { get; }

	protected override extern bool IsPositive { get; }

	public extern ShacklingPotionPower();
}
