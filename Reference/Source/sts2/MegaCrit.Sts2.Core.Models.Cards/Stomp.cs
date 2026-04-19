using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Stomp : CardModel
{
	public extern Stomp();

	public override extern Task AfterCardEnteredCombat(CardModel card);

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);
}
