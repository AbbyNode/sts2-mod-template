using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class FakeAnchor : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern int MerchantCost { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__8))]
	public override extern Task BeforeCombatStart();

	public extern FakeAnchor();
}
