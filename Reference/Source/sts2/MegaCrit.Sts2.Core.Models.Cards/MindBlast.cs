using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class MindBlast : CardModel
{
	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern MindBlast();
}
