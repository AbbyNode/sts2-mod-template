using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Malaise : CardModel
{
	public override extern TargetType TargetType { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Malaise();
}
