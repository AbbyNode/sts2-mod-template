using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BeltBuckle : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__10))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__11))]
	public override extern Task BeforeCombatStart();

	public override extern Task AfterCombatEnd(CombatRoom room);

	[AsyncStateMachine(typeof(_003CAfterPotionProcured_003Ed__13))]
	public override extern Task AfterPotionProcured(PotionModel potion);

	[AsyncStateMachine(typeof(_003CAfterPotionDiscarded_003Ed__14))]
	public override extern Task AfterPotionDiscarded(PotionModel potion);

	[AsyncStateMachine(typeof(_003CAfterPotionUsed_003Ed__15))]
	public override extern Task AfterPotionUsed(PotionModel potion, Creature? target);

	public override extern Task AfterCombatVictory(CombatRoom room);

	public extern BeltBuckle();
}
