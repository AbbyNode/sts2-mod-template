using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class MinionSacrifice : CardModel
{
	public override extern bool GainsBlock { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern MinionSacrifice();
}
