using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models.Potions;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class FakeMerchant : EventModel
{
	public const int relicCost = 50;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern MerchantDialogueSet Dialogue { get; }

	public override extern EventLayoutType LayoutType { get; }

	public override extern bool IsShared { get; }

	public extern MerchantInventory Inventory { get; }

	public extern bool StartedFight { get; }

	public override extern IEnumerable<LocString> GameInfoOptions { get; }

	public override extern bool IsAllowed(RunState runState);

	[AsyncStateMachine(typeof(_003CFoulPotionThrown_003Ed__22))]
	public extern Task FoulPotionThrown(FoulPotion potion);

	public extern FakeMerchant();
}
