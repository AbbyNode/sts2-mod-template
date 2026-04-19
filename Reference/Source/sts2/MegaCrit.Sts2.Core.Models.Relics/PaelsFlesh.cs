using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsFlesh : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern int DisplayAmount { get; }

	public override extern bool ShowCounter { get; }

	public override extern Task BeforeCombatStart();

	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__12))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public override extern Task AfterCombatEnd(CombatRoom room);

	public extern PaelsFlesh();
}
