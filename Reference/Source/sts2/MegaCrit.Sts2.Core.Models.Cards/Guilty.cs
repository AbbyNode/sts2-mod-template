using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Guilty : CardModel
{
	public const int maxCombats = 5;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	[SavedProperty]
	public extern int CombatsSeen { get; set; }

	public extern Guilty();

	[AsyncStateMachine(typeof(_003CAfterCombatEnd_003Ed__13))]
	public override extern Task AfterCombatEnd(CombatRoom _);
}
