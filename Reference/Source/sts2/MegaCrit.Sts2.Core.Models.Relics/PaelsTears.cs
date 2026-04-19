using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsTears : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__11))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public override extern Task AfterCombatEnd(CombatRoom room);

	public extern PaelsTears();
}
