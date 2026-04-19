using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Distraction : CardModel
{
	public override extern CardPoolModel VisualCardPool { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Distraction();
}
