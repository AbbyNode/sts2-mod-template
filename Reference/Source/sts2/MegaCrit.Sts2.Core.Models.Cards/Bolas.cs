using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Bolas : CardModel
{
	public extern Bolas();

	[AsyncStateMachine(typeof(_003CBeforeHandDraw_003Ed__6))]
	public override extern Task BeforeHandDraw(Player player, PlayerChoiceContext choiceContext, CombatState combatState);
}
