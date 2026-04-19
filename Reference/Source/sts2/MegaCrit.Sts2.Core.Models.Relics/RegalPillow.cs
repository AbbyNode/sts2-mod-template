using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class RegalPillow : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyRestSiteHealAmount(Creature creature, decimal amount);

	public override extern Task AfterRestSiteHeal(Player player, bool isMimicked);

	public override extern IReadOnlyList<LocString> ModifyExtraRestSiteHealText(Player player, IReadOnlyList<LocString> currentExtraText);

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern RegalPillow();
}
