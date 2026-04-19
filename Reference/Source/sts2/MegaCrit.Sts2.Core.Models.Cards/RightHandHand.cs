using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class RightHandHand : CardModel
{
	public extern RightHandHand();

	[AsyncStateMachine(typeof(_003CAfterCardPlayedLate_003Ed__10))]
	public override extern Task AfterCardPlayedLate(PlayerChoiceContext choiceContext, CardPlay cardPlay);
}
