namespace MegaCrit.Sts2.Core.Models.Powers;

public class ManglePower : TemporaryStrengthPower
{
	public override extern AbstractModel OriginModel { get; }

	protected override extern bool IsPositive { get; }

	public extern ManglePower();
}
