using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class SkillRegent2Achievement : AchievementModel
{
	public override extern Task AfterStarsGained(int amount, Player gainer);

	public extern SkillRegent2Achievement();
}
