namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Stack : CardModel
{
	public override extern CardPoolModel VisualCardPool { get; }

	public override extern bool GainsBlock { get; }

	public extern Stack();
}
