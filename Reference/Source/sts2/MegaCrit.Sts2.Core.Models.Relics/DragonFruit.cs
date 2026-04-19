using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class DragonFruit : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool IsAllowed(IRunState runState);

	[AsyncStateMachine(typeof(_003CAfterGoldGained_003Ed__5))]
	public override extern Task AfterGoldGained(Player player);

	public extern DragonFruit();
}
