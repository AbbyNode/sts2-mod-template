using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PetrifiedToad : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStartLate_003Ed__4))]
	public override extern Task BeforeCombatStartLate();

	public extern PetrifiedToad();
}
