using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class OrbCmd
{
	public static extern Task AddSlots(Player player, int amount);

	public static extern void RemoveSlots(Player player, int amount);

	[AsyncStateMachine(typeof(_003CChannel_003Ed__2<>))]
	public static extern Task Channel<T>(PlayerChoiceContext choiceContext, Player player) where T : OrbModel;

	[AsyncStateMachine(typeof(_003CChannel_003Ed__3))]
	public static extern Task Channel(PlayerChoiceContext choiceContext, OrbModel orb, Player player);

	[AsyncStateMachine(typeof(_003CEvokeNext_003Ed__4))]
	public static extern Task EvokeNext(PlayerChoiceContext choiceContext, Player player, bool dequeue = true);

	[AsyncStateMachine(typeof(_003CEvokeLast_003Ed__5))]
	public static extern Task EvokeLast(PlayerChoiceContext choiceContext, Player player, bool dequeue = true);

	[AsyncStateMachine(typeof(_003CPassive_003Ed__7))]
	public static extern Task Passive(PlayerChoiceContext choiceContext, OrbModel orb, Creature? target);

	public static extern Task Replace(OrbModel oldOrb, OrbModel newOrb, Player player);

	public static extern void IncreaseBaseOrbCount(Player player, int amount);
}
