using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class DingyRug : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern CardCreationOptions ModifyCardRewardCreationOptions(Player player, CardCreationOptions options);

	public extern DingyRug();
}
