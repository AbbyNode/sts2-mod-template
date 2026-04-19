using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands.Builders;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Flatten : CardModel
{
	public extern Flatten();

	public override extern Task AfterCardEnteredCombat(CardModel card);

	public override extern Task AfterAttack(AttackCommand command);
}
