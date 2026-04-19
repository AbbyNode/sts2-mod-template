using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Rewards;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class TinyMailbox : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool TryModifyRestSiteHealRewards(Player player, List<Reward> rewards, bool isMimicked);

	public override extern IReadOnlyList<LocString> ModifyExtraRestSiteHealText(Player player, IReadOnlyList<LocString> currentExtraText);

	public extern TinyMailbox();
}
