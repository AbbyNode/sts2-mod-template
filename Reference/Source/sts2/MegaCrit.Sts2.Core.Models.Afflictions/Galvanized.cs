namespace MegaCrit.Sts2.Core.Models.Afflictions;

public sealed class Galvanized : AfflictionModel
{
	public override extern bool IsStackable { get; }

	public override extern bool HasExtraCardText { get; }

	public extern Galvanized();
}
