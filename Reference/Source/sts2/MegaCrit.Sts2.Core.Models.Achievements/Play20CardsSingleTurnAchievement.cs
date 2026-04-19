using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class Play20CardsSingleTurnAchievement : AchievementModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern Play20CardsSingleTurnAchievement();
}
