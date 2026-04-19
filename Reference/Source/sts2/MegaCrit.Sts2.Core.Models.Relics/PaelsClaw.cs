using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsClaw : RelicModel
{
	public const int cardsCount = 3;

	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterObtained();

	public extern PaelsClaw();
}
