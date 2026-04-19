using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rewards;

public class SpecialCardReward : Reward
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	protected override extern RewardType RewardType { get; }

	public override extern int RewardsSetIndex { get; }

	protected override extern string IconPath { get; }

	public override extern LocString Description { get; }

	protected override extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public override extern bool IsPopulated { get; }

	public extern SpecialCardReward(CardModel card, Player player);

	public extern void SetCustomDescriptionEncounterSource(ModelId encounterId);

	public override extern Task Populate();

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__22))]
	protected override extern Task<bool> OnSelect();

	public override extern void OnSkipped();

	public override extern SerializableReward ToSerializable();

	public override extern void MarkContentAsSeen();
}
