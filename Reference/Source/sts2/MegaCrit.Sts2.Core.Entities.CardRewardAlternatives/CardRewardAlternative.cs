using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Rewards;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Rewards;

namespace MegaCrit.Sts2.Core.Entities.CardRewardAlternatives;

public class CardRewardAlternative
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string OptionId
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString Title { get; }

	public extern string Hotkey
	{
		[CompilerGenerated]
		get;
	}

	public extern Func<Task> OnSelect
	{
		[CompilerGenerated]
		get;
	}

	public extern PostAlternateCardRewardAction AfterSelected
	{
		[CompilerGenerated]
		get;
	}

	public extern CardRewardAlternative(string optionId, PostAlternateCardRewardAction afterSelected);

	public extern CardRewardAlternative(string optionId, Func<Task> onSelect, PostAlternateCardRewardAction afterSelected);

	public static extern IReadOnlyList<CardRewardAlternative> Generate(CardReward cardReward);
}
