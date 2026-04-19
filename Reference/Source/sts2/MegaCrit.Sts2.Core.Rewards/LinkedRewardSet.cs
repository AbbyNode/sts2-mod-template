using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Rewards;

public class LinkedRewardSet : Reward
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	public static extern HoverTip HoverTip { get; }

	public extern IReadOnlyList<Reward> Rewards { get; }

	public override extern bool IsPopulated { get; }

	public override extern LocString Description { get; }

	public extern LinkedRewardSet(List<Reward> rewards, Player player);

	[AsyncStateMachine(typeof(_003CPopulate_003Ed__16))]
	public override extern Task Populate();

	public extern void RemoveReward(Reward reward);

	protected override extern Task<bool> OnSelect();

	public override extern void OnSkipped();

	public override extern void MarkContentAsSeen();
}
