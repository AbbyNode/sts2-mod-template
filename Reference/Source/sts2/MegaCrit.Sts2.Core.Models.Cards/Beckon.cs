using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Beckon : CardModel
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern bool HasTurnEndInHandEffect { get; }

	public extern Beckon();

	[AsyncStateMachine(typeof(_003COnTurnEndInHand_003Ed__7))]
	public override extern Task OnTurnEndInHand(PlayerChoiceContext choiceContext);
}
