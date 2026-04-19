using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Alchemize : CardModel
{
	public override extern bool CanBeGeneratedInCombat { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Alchemize();
}
