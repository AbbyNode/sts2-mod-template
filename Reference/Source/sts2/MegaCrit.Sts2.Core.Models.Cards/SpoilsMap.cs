using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class SpoilsMap : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	[SavedProperty]
	public extern int SpoilsActIndex { get; set; }

	public extern MapCoord? SpoilsCoord
	{
		[CompilerGenerated]
		get;
	}

	public extern SpoilsMap();

	public override extern void AfterCreated();

	public override extern ActMap ModifyGeneratedMap(IRunState runState, ActMap map, int actIndex);

	public override extern ActMap ModifyGeneratedMapLate(IRunState runState, ActMap map, int actIndex);

	public override extern Task AfterMapGenerated(ActMap map, int actIndex);

	public override extern Task BeforeCardRemoved(CardModel card);

	[AsyncStateMachine(typeof(_003COnQuestComplete_003Ed__20))]
	public extern Task<int> OnQuestComplete();
}
