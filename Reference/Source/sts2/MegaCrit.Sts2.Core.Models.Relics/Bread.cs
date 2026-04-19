using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Bread : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__9))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern Bread();
}
