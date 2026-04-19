using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Crossbow : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__2))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern Crossbow();
}
