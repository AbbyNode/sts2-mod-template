using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Discovery : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Discovery();

	public extern void MockSelectedCard(CardModel card);
}
