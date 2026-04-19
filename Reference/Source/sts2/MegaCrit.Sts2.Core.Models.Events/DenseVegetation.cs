namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class DenseVegetation : EventModel
{
	public override extern bool IsShared { get; }

	public override extern void CalculateVars();

	public extern DenseVegetation();
}
