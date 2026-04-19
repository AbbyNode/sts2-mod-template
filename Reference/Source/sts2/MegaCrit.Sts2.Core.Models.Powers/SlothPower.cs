using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SlothPower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int DisplayAmount { get; }

	public override extern bool ShouldPlay(CardModel card, AutoPlayType _);

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public extern SlothPower();
}
