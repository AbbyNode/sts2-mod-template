using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class RampartPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldScaleInMultiplayer { get; }

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__6))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern RampartPower();
}
