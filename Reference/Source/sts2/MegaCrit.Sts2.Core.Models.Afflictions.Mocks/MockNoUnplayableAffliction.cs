namespace MegaCrit.Sts2.Core.Models.Afflictions.Mocks;

public sealed class MockNoUnplayableAffliction : AfflictionModel
{
	public override extern bool CanAfflictUnplayableCards { get; }

	public extern MockNoUnplayableAffliction();
}
