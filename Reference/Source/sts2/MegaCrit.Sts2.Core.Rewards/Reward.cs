using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rewards;

public abstract class Reward
{
	protected Rng? _rngOverride;

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	protected abstract RewardType RewardType { get; }

	public abstract int RewardsSetIndex { get; }

	public abstract LocString Description { get; }

	public abstract bool IsPopulated { get; }

	protected virtual extern string? IconPath { get; }

	public virtual extern Vector2 IconPosition { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public virtual extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern LinkedRewardSet? ParentRewardSet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected extern Reward(Player player);

	public abstract Task Populate();

	protected abstract Task<bool> OnSelect();

	public virtual extern Control? CreateIcon();

	public virtual extern void OnSkipped();

	[AsyncStateMachine(typeof(_003COnSelectWrapper_003Ed__29))]
	public extern Task<bool> OnSelectWrapper();

	public abstract void MarkContentAsSeen();

	public virtual extern SerializableReward ToSerializable();

	public extern Reward SetRng(Rng rng);

	public static extern Reward FromSerializable(SerializableReward save, Player player);
}
