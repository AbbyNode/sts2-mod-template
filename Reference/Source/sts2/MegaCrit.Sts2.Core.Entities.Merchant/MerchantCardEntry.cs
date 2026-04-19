using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public sealed class MerchantCardEntry : MerchantEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardCreationResult? CreationResult
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsOnSale
	{
		[CompilerGenerated]
		get;
	}

	public override extern bool IsStocked { get; }

	public extern MerchantCardEntry(Player player, MerchantInventory? inventory, IEnumerable<CardModel> cardPool, CardType cardType);

	public extern MerchantCardEntry(Player player, MerchantInventory? inventory, IEnumerable<CardModel> cardPool, CardRarity cardRarity);

	public extern void Populate();

	public extern void SetOnSale();

	public override extern void CalcCost();
}
