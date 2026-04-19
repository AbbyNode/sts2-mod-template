using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BoundPhylactery : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool SpawnsPets { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__8))]
	public override extern Task BeforeCombatStart();

	[AsyncStateMachine(typeof(_003CAfterEnergyResetLate_003Ed__9))]
	public override extern Task AfterEnergyResetLate(Player player);

	public extern BoundPhylactery();
}
