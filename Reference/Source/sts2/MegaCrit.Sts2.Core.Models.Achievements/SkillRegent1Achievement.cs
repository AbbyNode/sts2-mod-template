using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Achievements;

public class SkillRegent1Achievement : AchievementModel
{
	public override extern Task AfterForge(decimal amount, Player forger, AbstractModel? source);

	public extern SkillRegent1Achievement();
}
