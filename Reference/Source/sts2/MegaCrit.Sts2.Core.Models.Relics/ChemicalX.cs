using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ChemicalX : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public override extern int ModifyXValue(CardModel card, int originalValue);

	public extern ChemicalX();
}
