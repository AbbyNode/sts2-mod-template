using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Vigorous : EnchantmentModel
{
	public override extern bool ShowAmount { get; }

	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern decimal EnchantDamageAdditive(decimal originalDamage, ValueProp props);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public extern Vigorous();
}
