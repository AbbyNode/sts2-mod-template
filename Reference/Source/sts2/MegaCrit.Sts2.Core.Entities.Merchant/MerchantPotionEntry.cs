using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public sealed class MerchantPotionEntry : MerchantEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PotionModel? Model
	{
		[CompilerGenerated]
		get;
	}

	public override extern bool IsStocked { get; }

	public extern MerchantPotionEntry(PotionModel potion, Player player);

	public extern MerchantPotionEntry(Player player);

	public override extern void CalcCost();
}
