using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ThrowingAxe : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern int ModifyCardPlayCount(CardModel card, Creature? target, int playCount);

	public override extern Task AfterModifyingCardPlayCount(CardModel card);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern ThrowingAxe();
}
