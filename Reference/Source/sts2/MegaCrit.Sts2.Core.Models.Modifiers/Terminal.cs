using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Terminal : ModifierModel
{
	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__0))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern Terminal();
}
