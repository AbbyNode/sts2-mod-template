using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Murderous : ModifierModel
{
	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__1))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern Task AfterCreatureAddedToCombat(Creature creature);

	public extern Murderous();
}
