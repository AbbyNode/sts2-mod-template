using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class OstyCmd
{
	[AsyncStateMachine(typeof(_003CSummon_003Ed__0))]
	public static extern Task<SummonResult> Summon(PlayerChoiceContext choiceContext, Player summoner, decimal amount, AbstractModel? source);
}
