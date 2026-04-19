using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ScrollBoxes : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__3))]
	public override extern Task AfterObtained();

	public static extern bool CanGenerateBundles(Player player);

	public static extern List<IReadOnlyList<CardModel>> GenerateRandomBundles(Player player);

	public extern ScrollBoxes();
}
