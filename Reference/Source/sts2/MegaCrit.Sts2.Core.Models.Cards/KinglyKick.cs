using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class KinglyKick : CardModel
{
	public extern KinglyKick();

	public override extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);
}
