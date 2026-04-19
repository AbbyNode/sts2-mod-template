using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class DyingStar : CardModel
{
	public override extern int CanonicalStarCost { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern DyingStar();
}
