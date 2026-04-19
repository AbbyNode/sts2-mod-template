using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class WarPaint : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	public override extern Task AfterObtained();

	public extern WarPaint();
}
