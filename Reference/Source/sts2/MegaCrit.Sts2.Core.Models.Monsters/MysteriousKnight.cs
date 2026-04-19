using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public class MysteriousKnight : FlailKnight
{
	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__0))]
	public override extern Task AfterAddedToRoom();

	public extern MysteriousKnight();
}
