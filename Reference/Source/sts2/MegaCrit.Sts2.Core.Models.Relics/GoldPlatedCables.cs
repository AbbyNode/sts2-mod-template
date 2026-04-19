using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class GoldPlatedCables : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern int ModifyOrbPassiveTriggerCounts(OrbModel orb, int triggerCount);

	public override extern Task AfterModifyingOrbPassiveTriggerCount(OrbModel orb);

	public extern GoldPlatedCables();
}
