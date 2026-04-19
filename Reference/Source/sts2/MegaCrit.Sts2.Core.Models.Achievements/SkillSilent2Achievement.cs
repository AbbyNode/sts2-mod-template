using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class SkillSilent2Achievement : AchievementModel
{
	public override extern Task AfterPowerAmountChanged(PowerModel power, decimal amount, Creature? applier, CardModel? cardSource);

	public extern SkillSilent2Achievement();
}
