using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Ignition : CardModel
{
	public override extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Ignition();
}
