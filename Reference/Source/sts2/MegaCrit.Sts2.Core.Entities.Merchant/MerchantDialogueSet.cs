using System.Collections.Generic;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public class MerchantDialogueSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<LocString> WelcomeLines { get; }

	public extern IReadOnlyList<LocString> FoulPotionLines { get; }

	public extern IReadOnlyList<LocString> PlayerDeadLines { get; }

	public extern IReadOnlyList<LocString> OpenInventoryLines { get; }

	public static extern MerchantDialogueSet CreateFromLocStrings(IEnumerable<LocString> locStrings);

	public extern IReadOnlyList<LocString> GetPurchaseSuccessLines(PurchaseStatus status);

	public extern MerchantDialogueSet();
}
