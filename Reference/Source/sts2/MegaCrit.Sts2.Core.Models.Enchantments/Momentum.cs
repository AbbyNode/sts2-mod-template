using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Momentum : EnchantmentModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool HasExtraCardText { get; }

	public override extern bool ShowAmount { get; }

	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay? cardPlay);

	public override extern decimal EnchantDamageAdditive(decimal originalDamage, ValueProp props);

	public extern Momentum();
}
