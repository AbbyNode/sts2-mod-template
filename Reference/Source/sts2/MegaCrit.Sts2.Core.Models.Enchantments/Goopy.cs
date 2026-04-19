using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Goopy : EnchantmentModel
{
	public override extern bool HasExtraCardText { get; }

	public override extern bool CanEnchant(CardModel card);

	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public override extern decimal EnchantBlockAdditive(decimal originalBlock, ValueProp props);

	public extern Goopy();
}
