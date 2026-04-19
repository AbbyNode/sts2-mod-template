using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PhylacteryUnbound : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool SpawnsPets { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__10))]
	public override extern Task BeforeCombatStart();

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__11))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern PhylacteryUnbound();
}
