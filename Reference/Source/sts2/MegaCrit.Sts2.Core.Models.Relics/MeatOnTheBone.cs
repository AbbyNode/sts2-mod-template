using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class MeatOnTheBone : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern Task BeforeCombatStart();

	public override extern Task AfterCurrentHpChanged(Creature creature, decimal delta);

	[AsyncStateMachine(typeof(_003CAfterCombatVictoryEarly_003Ed__7))]
	public override extern Task AfterCombatVictoryEarly(CombatRoom _);

	public extern MeatOnTheBone();
}
