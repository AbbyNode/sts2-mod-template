using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rewards;

public class CardReward : Reward
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	protected override extern string IconPath { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern LocString Description { get; }

	public extern IEnumerable<CardModel> Cards { get; }

	public extern bool CanReroll
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool CanSkip
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public override extern bool IsPopulated { get; }

	public extern event Action? AfterGenerated;

	public extern CardReward(CardCreationOptions options, int cardCount, Player player);

	public extern CardReward(IEnumerable<CardModel> cardsToOffer, CardCreationSource source, Player player);

	public override extern Task Populate();

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__44))]
	protected override extern Task<bool> OnSelect();

	public override extern void OnSkipped();

	[AsyncStateMachine(typeof(_003CReroll_003Ed__46))]
	public extern Task Reroll();

	public override extern SerializableReward ToSerializable();

	public override extern void MarkContentAsSeen();
}
