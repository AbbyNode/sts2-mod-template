using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Glam : EnchantmentModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int EnchantPlayCount(int originalPlayCount);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public extern Glam();
}
