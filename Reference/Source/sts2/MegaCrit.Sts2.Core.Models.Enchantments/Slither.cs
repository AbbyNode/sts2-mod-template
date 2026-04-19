using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Slither : EnchantmentModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int TestEnergyCostOverride { get; set; }

	public override extern bool CanEnchant(CardModel card);

	public override extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	public extern Slither();
}
