using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class RocketPunch : CardModel
{
	public extern RocketPunch();

	public override extern Task AfterCardGeneratedForCombat(CardModel card, bool addedByPlayer);
}
