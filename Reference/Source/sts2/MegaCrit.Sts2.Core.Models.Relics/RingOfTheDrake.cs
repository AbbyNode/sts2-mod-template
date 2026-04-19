using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class RingOfTheDrake : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyHandDraw(Player player, decimal count);

	public extern RingOfTheDrake();
}
