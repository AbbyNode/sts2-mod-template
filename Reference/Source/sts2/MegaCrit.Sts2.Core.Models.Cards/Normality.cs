using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Normality : CardModel
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Normality();

	public override extern bool ShouldPlay(CardModel card, AutoPlayType _);
}
