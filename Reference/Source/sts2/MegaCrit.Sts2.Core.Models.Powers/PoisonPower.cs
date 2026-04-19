using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class PoisonPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern Color AmountLabelColor { get; }

	public extern int CalculateTotalDamageNextTurn();

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__9))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern PoisonPower();
}
