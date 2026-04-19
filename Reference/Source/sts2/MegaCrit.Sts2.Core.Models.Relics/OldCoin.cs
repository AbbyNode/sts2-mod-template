using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class OldCoin : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	public override extern bool IsAllowed(IRunState runState);

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__7))]
	public override extern Task AfterObtained();

	public extern OldCoin();
}
