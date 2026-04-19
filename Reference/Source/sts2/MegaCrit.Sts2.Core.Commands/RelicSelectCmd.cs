using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class RelicSelectCmd
{
	[AsyncStateMachine(typeof(_003CFromChooseARelicScreen_003Ed__1))]
	public static extern Task<RelicModel?> FromChooseARelicScreen(Player player, IReadOnlyList<RelicModel> relics);
}
