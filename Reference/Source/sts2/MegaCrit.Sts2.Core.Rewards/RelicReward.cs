using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Rewards;

public class RelicReward : Reward
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	public extern RelicRarity Rarity { get; }

	public extern RelicModel? ClaimedRelic
	{
		[CompilerGenerated]
		get;
	}

	public override extern LocString Description { get; }

	protected override extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public override extern bool IsPopulated { get; }

	public extern RelicReward(Player player);

	public extern RelicReward(RelicModel relic, Player player);

	public extern RelicReward(RelicRarity rarity, Player player);

	public override extern Task Populate();

	public override extern TextureRect CreateIcon();

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__24))]
	protected override extern Task<bool> OnSelect();

	public override extern void OnSkipped();

	public override extern void MarkContentAsSeen();
}
