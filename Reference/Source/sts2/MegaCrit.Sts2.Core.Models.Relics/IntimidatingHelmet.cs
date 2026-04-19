using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class IntimidatingHelmet : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CBeforeCardPlayed_003Ed__6))]
	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public extern IntimidatingHelmet();
}
