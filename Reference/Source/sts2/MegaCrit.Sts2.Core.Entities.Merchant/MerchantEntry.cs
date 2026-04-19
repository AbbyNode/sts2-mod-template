using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public abstract class MerchantEntry
{
	protected readonly Player _player;

	protected int _cost;

	public extern int Cost { get; }

	public extern bool EnoughGold { get; }

	public abstract bool IsStocked { get; }

	public extern event Action<PurchaseStatus, MerchantEntry>? PurchaseCompleted;

	public extern event Action<PurchaseStatus>? PurchaseFailed;

	public extern event Action? EntryUpdated;

	public extern void InvokePurchaseCompleted(MerchantEntry entry);

	public extern void InvokePurchaseFailed(PurchaseStatus status);

	protected extern MerchantEntry(Player player);

	protected virtual extern void UpdateEntry();

	public extern void OnMerchantInventoryUpdated();

	public abstract void CalcCost();

	[AsyncStateMachine(typeof(_003COnTryPurchaseWrapper_003Ed__23))]
	public extern Task<bool> OnTryPurchaseWrapper(MerchantInventory? inventory, bool ignoreCost = false);

	protected abstract Task<(bool, int)> OnTryPurchase(MerchantInventory? inventory, bool ignoreCost);

	protected abstract void ClearAfterPurchase();

	protected abstract void RestockAfterPurchase(MerchantInventory? inventory);
}
