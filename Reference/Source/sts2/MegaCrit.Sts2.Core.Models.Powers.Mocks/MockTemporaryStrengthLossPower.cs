namespace MegaCrit.Sts2.Core.Models.Powers.Mocks;

public class MockTemporaryStrengthLossPower : TemporaryStrengthPower
{
	public override extern AbstractModel OriginModel { get; }

	protected override extern bool IsPositive { get; }

	public extern MockTemporaryStrengthLossPower();
}
