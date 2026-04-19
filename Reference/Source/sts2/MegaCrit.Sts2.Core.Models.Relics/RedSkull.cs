using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class RedSkull : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__11))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern Task AfterCombatEnd(CombatRoom _);

	[AsyncStateMachine(typeof(_003CAfterCurrentHpChanged_003Ed__13))]
	public override extern Task AfterCurrentHpChanged(Creature creature, decimal _);

	public extern RedSkull();
}
