using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class HappyFlower : RelicModel
{
	public const int turnsThreshold = 3;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int TurnsSeen { get; set; }

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__20))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern HappyFlower();
}
