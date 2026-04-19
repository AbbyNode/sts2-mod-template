using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Circlet : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool IsStackable { get; }

	public extern Circlet();
}
