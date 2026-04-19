using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class DeprecatedRelic : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool IsStackable { get; }

	public extern DeprecatedRelic();
}
