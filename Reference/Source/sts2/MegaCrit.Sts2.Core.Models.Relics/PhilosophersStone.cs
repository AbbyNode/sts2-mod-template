using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PhilosophersStone : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public override extern Task AfterCreatureAddedToCombat(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__8))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern PhilosophersStone();
}
