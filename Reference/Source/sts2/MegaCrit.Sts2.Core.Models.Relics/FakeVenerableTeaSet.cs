using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class FakeVenerableTeaSet : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern int MerchantCost { get; }

	[SavedProperty]
	public extern bool GainEnergyInNextCombat { get; set; }

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern Task AfterEnergyReset(Player player);

	public extern FakeVenerableTeaSet();
}
