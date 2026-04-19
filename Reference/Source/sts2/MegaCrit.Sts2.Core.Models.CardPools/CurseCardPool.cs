using Godot;

namespace MegaCrit.Sts2.Core.Models.CardPools;

public sealed class CurseCardPool : CardPoolModel
{
	public override extern string Title { get; }

	public override extern string EnergyColorName { get; }

	public override extern string CardFrameMaterialPath { get; }

	public override extern Color DeckEntryCardColor { get; }

	public override extern bool IsColorless { get; }

	public extern CurseCardPool();
}
