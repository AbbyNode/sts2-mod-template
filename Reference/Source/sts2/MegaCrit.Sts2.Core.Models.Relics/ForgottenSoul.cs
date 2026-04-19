using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ForgottenSoul : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterCardExhausted_003Ed__4))]
	public override extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool _);

	public extern ForgottenSoul();
}
