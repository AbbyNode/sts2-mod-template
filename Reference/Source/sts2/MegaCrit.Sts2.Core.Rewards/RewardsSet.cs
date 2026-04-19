using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Rewards;

public class RewardsSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern AbstractRoom? Room
	{
		[CompilerGenerated]
		get;
	}

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern List<Reward> Rewards
	{
		[CompilerGenerated]
		get;
	}

	public extern RewardsSet(Player player);

	public extern RewardsSet EmptyForRoom(AbstractRoom room);

	public extern RewardsSet WithRewardsFromRoom(AbstractRoom room);

	public extern RewardsSet WithCustomRewards(List<Reward> rewards);

	[AsyncStateMachine(typeof(_003CGenerateWithoutOffering_003Ed__15))]
	public extern Task<List<Reward>> GenerateWithoutOffering();

	[AsyncStateMachine(typeof(_003COffer_003Ed__16))]
	public extern Task Offer();
}
