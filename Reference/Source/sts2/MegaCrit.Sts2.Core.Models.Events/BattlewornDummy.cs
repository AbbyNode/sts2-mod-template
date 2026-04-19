using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class BattlewornDummy : EventModel
{
	public override extern bool IsShared { get; }

	[AsyncStateMachine(typeof(_003CResume_003Ed__11))]
	public override extern Task Resume(AbstractRoom room);

	public extern BattlewornDummy();
}
