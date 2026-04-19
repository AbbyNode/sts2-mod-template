using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public sealed class MerchantRelicEntry : MerchantEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern RelicModel? Model
	{
		[CompilerGenerated]
		get;
	}

	public override extern bool IsStocked { get; }

	public extern MerchantRelicEntry(RelicRarity rarity, Player player);

	public extern MerchantRelicEntry(RelicModel relic, Player player);

	public override extern void CalcCost();
}
