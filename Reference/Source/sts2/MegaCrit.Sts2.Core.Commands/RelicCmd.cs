using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class RelicCmd
{
	[AsyncStateMachine(typeof(_003CObtain_003Ed__0<>))]
	public static extern Task<T> Obtain<T>(Player player) where T : RelicModel;

	[AsyncStateMachine(typeof(_003CObtain_003Ed__1))]
	public static extern Task<RelicModel> Obtain(RelicModel relic, Player player, int index = -1);

	[AsyncStateMachine(typeof(_003CRemove_003Ed__2))]
	public static extern Task Remove(RelicModel relic);

	[AsyncStateMachine(typeof(_003CReplace_003Ed__3))]
	public static extern Task<RelicModel> Replace(RelicModel original, RelicModel replace);

	[AsyncStateMachine(typeof(_003CMelt_003Ed__4))]
	public static extern Task Melt(RelicModel relic);
}
