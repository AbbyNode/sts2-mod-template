using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BigMushroom : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__6))]
	public override extern Task AfterObtained();

	public override extern Task AfterRoomEntered(AbstractRoom _);

	public override extern decimal ModifyHandDraw(Player player, decimal cardsToDraw);

	public extern BigMushroom();
}
