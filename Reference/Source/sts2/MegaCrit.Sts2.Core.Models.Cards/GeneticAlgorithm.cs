using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class GeneticAlgorithm : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool GainsBlock { get; }

	[SavedProperty]
	public extern int CurrentBlock { get; set; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	[SavedProperty]
	public extern int IncreasedBlock { get; set; }

	public extern GeneticAlgorithm();
}
