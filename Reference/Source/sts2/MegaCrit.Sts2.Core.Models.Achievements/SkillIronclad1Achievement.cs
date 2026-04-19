using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class SkillIronclad1Achievement : AchievementModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal);

	public override extern Task AfterRoomEntered(AbstractRoom room);

	public extern SkillIronclad1Achievement();
}
