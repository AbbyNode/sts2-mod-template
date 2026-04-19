using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Potions;

namespace MegaCrit.Sts2.Core.Models.Potions;

public sealed class FairyInABottle : PotionModel
{
	public override extern PotionRarity Rarity { get; }

	public override extern PotionUsage Usage { get; }

	public override extern TargetType TargetType { get; }

	public override extern bool CanBeGeneratedInCombat { get; }

	public override extern bool ShouldDie(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingDeath_003Ed__10))]
	public override extern Task AfterPreventingDeath(Creature creature);

	public extern FairyInABottle();
}
