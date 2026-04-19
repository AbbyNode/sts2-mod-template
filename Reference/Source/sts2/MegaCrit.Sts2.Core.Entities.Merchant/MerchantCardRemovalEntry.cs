using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.Merchant;

public sealed class MerchantCardRemovalEntry : MerchantEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool Used
	{
		[CompilerGenerated]
		get;
	}

	public override extern bool IsStocked { get; }

	public extern MerchantCardRemovalEntry(Player player);

	public override extern void CalcCost();

	public extern int CalcPriceIncrease();

	[AsyncStateMachine(typeof(_003COnTryPurchaseWrapper_003Ed__9))]
	public extern Task<bool> OnTryPurchaseWrapper(MerchantInventory? inventory, bool ignoreCost = false, bool cancelable = true);

	public extern void SetUsed();
}
