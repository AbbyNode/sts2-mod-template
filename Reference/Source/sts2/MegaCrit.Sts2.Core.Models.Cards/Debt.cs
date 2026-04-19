using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Debt : CardModel
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public override extern bool HasTurnEndInHandEffect { get; }

	public extern Debt();

	[AsyncStateMachine(typeof(_003COnTurnEndInHand_003Ed__9))]
	public override extern Task OnTurnEndInHand(PlayerChoiceContext choiceContext);
}
