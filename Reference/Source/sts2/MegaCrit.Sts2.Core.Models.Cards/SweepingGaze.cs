using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;

namespace MegaCrit.Sts2.Core.Models.Cards;

public class SweepingGaze : CardModel
{
	protected override extern bool ShouldGlowRedInternal { get; }

	protected override extern HashSet<CardTag> CanonicalTags { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	protected override extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern SweepingGaze();

	[AsyncStateMachine(typeof(_003COnPlay_003Ed__9))]
	protected override extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay cardPlay);

	protected override extern void OnUpgrade();
}
