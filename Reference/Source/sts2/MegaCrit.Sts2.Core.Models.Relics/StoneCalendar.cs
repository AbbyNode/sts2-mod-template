using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class StoneCalendar : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__14))]
	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern StoneCalendar();
}
