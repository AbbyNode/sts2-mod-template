using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class SkillSilent1Achievement : AchievementModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public override extern Task BeforeCardAutoPlayed(CardModel card, Creature? target, AutoPlayType type);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern SkillSilent1Achievement();
}
