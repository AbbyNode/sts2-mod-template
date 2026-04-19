using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class KinglyPunch : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern KinglyPunch();

	public override extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);
}
