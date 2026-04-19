using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Imbued : EnchantmentModel
{
	public override extern bool ShouldStartAtBottomOfDrawPile { get; }

	public override extern bool ShowAmount { get; }

	public override extern bool CanEnchantCardType(CardType cardType);

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStart_003Ed__5))]
	public override extern Task AfterPlayerTurnStart(PlayerChoiceContext choiceContext, Player player);

	public extern Imbued();
}
