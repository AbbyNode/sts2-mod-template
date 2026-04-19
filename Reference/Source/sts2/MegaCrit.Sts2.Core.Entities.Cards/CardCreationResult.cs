using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class CardCreationResult
{
	public readonly CardModel originalCard;

	public extern CardModel Card { get; }

	public extern IEnumerable<RelicModel> ModifyingRelics { get; }

	public extern bool HasBeenModified { get; }

	public extern CardCreationResult(CardModel originalCard);

	public extern void ModifyCard(CardModel card, RelicModel modifyingRelic);

	public extern void ModifyCard(CardModel card);
}
