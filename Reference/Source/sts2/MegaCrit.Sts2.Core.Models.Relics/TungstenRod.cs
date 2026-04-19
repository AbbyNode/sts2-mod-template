using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class TungstenRod : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyHpLostAfterOsty(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task AfterModifyingHpLostAfterOsty();

	public extern TungstenRod();
}
