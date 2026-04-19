using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class BigGameHunter : ModifierModel
{
	public override extern ActMap ModifyGeneratedMap(IRunState runState, ActMap map, int actIndex);

	public override extern CardCreationOptions ModifyCardRewardCreationOptions(Player player, CardCreationOptions options);

	public extern BigGameHunter();
}
