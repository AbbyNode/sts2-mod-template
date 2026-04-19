using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class LoomingFruit : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__9))]
	public override extern Task AfterObtained();

	public extern LoomingFruit();
}
