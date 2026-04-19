using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class DelicateFrond : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__2))]
	public override extern Task BeforeCombatStart();

	public extern DelicateFrond();
}
