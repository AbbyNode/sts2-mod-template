using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class MawBank : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldFlashOnPlayer { get; }

	public override extern bool IsUsedUp { get; }

	[SavedProperty]
	public extern bool HasItemBeenBought { get; set; }

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__12))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern Task AfterItemPurchased(Player player, MerchantEntry itemPurchased, int goldSpent);

	public extern MawBank();
}
