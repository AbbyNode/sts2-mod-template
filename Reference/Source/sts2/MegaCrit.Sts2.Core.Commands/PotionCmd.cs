using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Potions;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class PotionCmd
{
	[AsyncStateMachine(typeof(_003CTryToProcure_003Ed__0<>))]
	public static extern Task<PotionProcureResult> TryToProcure<T>(Player player) where T : PotionModel;

	[AsyncStateMachine(typeof(_003CTryToProcure_003Ed__1))]
	public static extern Task<PotionProcureResult> TryToProcure(PotionModel potion, Player player, int slotIndex = -1);

	[AsyncStateMachine(typeof(_003CDiscard_003Ed__2))]
	public static extern Task Discard(PotionModel potion);
}
