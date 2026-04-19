using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class SneckoSkull : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyPowerAmountGiven(PowerModel power, Creature giver, decimal amount, Creature? target, CardModel? cardSource);

	public override extern Task AfterModifyingPowerAmountGiven(PowerModel power);

	public extern SneckoSkull();
}
