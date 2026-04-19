using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class GoldenCompass : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	[SavedProperty]
	public extern int GoldenPathAct { get; set; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__8))]
	public override extern Task AfterObtained();

	public override extern ActMap ModifyGeneratedMap(IRunState runState, ActMap map, int actIndex);

	public override extern IReadOnlySet<RoomType> ModifyUnknownMapPointRoomTypes(IReadOnlySet<RoomType> roomTypes);

	public extern GoldenCompass();
}
