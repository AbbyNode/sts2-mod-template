using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Pinpoint : CardModel
{
	public extern Pinpoint();

	public override extern Task AfterCardEnteredCombat(CardModel card);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);
}
