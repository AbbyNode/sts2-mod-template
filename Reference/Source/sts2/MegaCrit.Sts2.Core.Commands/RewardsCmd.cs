using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Commands;

public static class RewardsCmd
{
	[AsyncStateMachine(typeof(_003COfferForRoomEnd_003Ed__0))]
	public static extern Task OfferForRoomEnd(Player player, AbstractRoom room);

	[AsyncStateMachine(typeof(_003COfferCustom_003Ed__1))]
	public static extern Task OfferCustom(Player player, List<Reward> rewards);

	[AsyncStateMachine(typeof(_003CGenerateForRoomEndDebug_003Ed__2))]
	public static extern Task<List<Reward>> GenerateForRoomEndDebug(Player player, AbstractRoom room);

	[AsyncStateMachine(typeof(_003CGenerateCustomDebug_003Ed__3))]
	public static extern Task<List<Reward>> GenerateCustomDebug(Player player, List<Reward> rewards);
}
