using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Corrupted : EnchantmentModel
{
	public override extern bool HasExtraCardText { get; }

	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern decimal EnchantDamageMultiplicative(decimal originalDamage, ValueProp props);

	[AsyncStateMachine(typeof(_003COnPlay_003Ed__5))]
	public override extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay? cardPlay);

	public extern Corrupted();
}
