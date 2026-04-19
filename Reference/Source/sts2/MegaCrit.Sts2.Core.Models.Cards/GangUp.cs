using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class GangUp : CardModel
{
	public override extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public extern GangUp();
}
