using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class WarHammer : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterCombatVictory(CombatRoom room);

	public extern WarHammer();
}
