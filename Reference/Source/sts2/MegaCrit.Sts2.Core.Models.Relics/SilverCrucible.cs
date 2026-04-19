using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class SilverCrucible : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsUsedUp { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int TimesUsed { get; set; }

	[SavedProperty]
	public extern int TreasureRoomsEntered { get; set; }

	public override extern bool TryModifyCardRewardOptionsLate(Player player, List<CardCreationResult> cardRewards, CardCreationOptions options);

	public override extern Task AfterModifyingCardRewardOptions();

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern bool ShouldGenerateTreasure(Player player);

	public extern SilverCrucible();
}
