using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Sneaky : CardModel
{
	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public override extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public extern Sneaky();
}
