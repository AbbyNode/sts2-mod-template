using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class SlumberingEssence : EnchantmentModel
{
	public override extern Task BeforeFlush(PlayerChoiceContext choiceContext, Player player);

	public extern SlumberingEssence();
}
