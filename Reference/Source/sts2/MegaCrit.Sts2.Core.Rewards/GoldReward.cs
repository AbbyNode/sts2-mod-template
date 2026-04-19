using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rewards;

public class GoldReward : Reward
{
	public const int defaultMinGoldAmount = 10;

	public const int defaultMaxGoldAmount = 20;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	protected override extern string IconPath { get; }

	public override extern Vector2 IconPosition { get; }

	public extern int Amount
	{
		[CompilerGenerated]
		get;
	}

	public override extern LocString Description { get; }

	public override extern bool IsPopulated { get; }

	public extern GoldReward(int amount, Player player, bool wasGoldStolenBack = false);

	public extern GoldReward(int min, int max, Player player, bool wasGoldStolenBack = false);

	public override extern Task Populate();

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__28))]
	protected override extern Task<bool> OnSelect();

	public override extern SerializableReward ToSerializable();

	public override extern void MarkContentAsSeen();
}
