using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Swift : EnchantmentModel
{
	public override extern bool HasExtraCardText { get; }

	public override extern bool ShowAmount { get; }

	[AsyncStateMachine(typeof(_003COnPlay_003Ed__4))]
	public override extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay? cardPlay);

	public extern Swift();
}
