using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Enthralled : CardModel
{
	public override extern bool CanBeGeneratedByModifiers { get; }

	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Enthralled();

	public override extern bool ShouldPlay(CardModel card, AutoPlayType autoPlayType);
}
