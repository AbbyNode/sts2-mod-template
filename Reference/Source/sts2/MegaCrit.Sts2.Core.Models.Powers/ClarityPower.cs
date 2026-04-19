using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class ClarityPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern decimal ModifyHandDraw(Player player, decimal count);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__5))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern ClarityPower();
}
