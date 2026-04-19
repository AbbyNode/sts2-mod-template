using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;

namespace MegaCrit.Sts2.Core.Commands;

public static class ForgeCmd
{
	[AsyncStateMachine(typeof(_003CForge_003Ed__2))]
	public static extern Task<IEnumerable<SovereignBlade>> Forge(decimal amount, Player player, AbstractModel? source);

	public static extern void PlayCombatRoomForgeVfx(Player player, CardModel card);
}
