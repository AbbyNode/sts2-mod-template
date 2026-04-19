using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Rewards;

public class CardRemovalReward : Reward
{
	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	protected override extern string IconPath { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern bool IsPopulated { get; }

	public override extern LocString Description { get; }

	public extern CardRemovalReward(Player player);

	public override extern Task Populate();

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__16))]
	protected override extern Task<bool> OnSelect();

	public override extern void MarkContentAsSeen();
}
