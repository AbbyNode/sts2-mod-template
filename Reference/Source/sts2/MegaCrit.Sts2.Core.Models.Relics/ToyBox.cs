using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ToyBox : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern LocString WaxRelicPrefix { get; }

	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	public override extern bool IsUsedUp { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int CombatsSeen { get; set; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__24))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CAfterCombatEnd_003Ed__25))]
	public override extern Task AfterCombatEnd(CombatRoom __);

	public extern ToyBox();
}
