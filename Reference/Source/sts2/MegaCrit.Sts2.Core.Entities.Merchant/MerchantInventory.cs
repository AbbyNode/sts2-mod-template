using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public class MerchantInventory
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<MerchantCardEntry> CharacterCardEntries { get; }

	public extern IReadOnlyList<MerchantCardEntry> ColorlessCardEntries { get; }

	public extern IReadOnlyList<MerchantRelicEntry> RelicEntries { get; }

	public extern IReadOnlyList<MerchantPotionEntry> PotionEntries { get; }

	public extern MerchantCardRemovalEntry? CardRemovalEntry
	{
		[CompilerGenerated]
		get;
	}

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<MerchantEntry> AllEntries { get; }

	public extern IEnumerable<MerchantCardEntry> CardEntries { get; }

	public extern MerchantInventory(Player player);

	public static extern MerchantInventory CreateForNormalMerchant(Player player);

	public extern void AddRelicEntry(MerchantRelicEntry entry);
}
