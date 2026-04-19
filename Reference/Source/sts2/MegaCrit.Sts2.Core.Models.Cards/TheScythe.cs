using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class TheScythe : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[SavedProperty]
	public extern int CurrentDamage { get; set; }

	[SavedProperty]
	public extern int IncreasedDamage { get; set; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern TheScythe();
}
