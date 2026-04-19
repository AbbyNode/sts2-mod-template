using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class CharacterCards : ModifierModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public override extern LocString Description { get; }

	[SavedProperty]
	public extern ModelId CharacterModel { get; set; }

	public override extern IEnumerable<CardModel> ModifyMerchantCardPool(Player player, IEnumerable<CardModel> options);

	public override extern CardCreationOptions ModifyCardRewardCreationOptions(Player player, CardCreationOptions options);

	public override extern bool IsEquivalent(ModifierModel other);

	public extern CharacterCards();
}
