using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Intercept : CardModel
{
	public override extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public override extern bool GainsBlock { get; }

	public extern Intercept();
}
