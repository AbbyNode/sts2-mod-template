namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class HandOfGreed : CardModel
{
	public const int goldAmount = 20;

	public override extern bool CanBeGeneratedInCombat { get; }

	public extern HandOfGreed();
}
