using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class EmberTea : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsUsedUp { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int CombatsLeft { get; set; }

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__17))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern EmberTea();
}
