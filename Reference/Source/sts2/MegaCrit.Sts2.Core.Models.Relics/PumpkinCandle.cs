using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PumpkinCandle : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	[SavedProperty]
	public extern int ActiveAct { get; set; }

	public override extern Task AfterObtained();

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public override extern Task AfterRoomEntered(AbstractRoom _);

	public extern PumpkinCandle();
}
