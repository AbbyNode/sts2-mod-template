using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class SovereignBlade : CardModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern TargetType TargetType { get; }

	public extern bool CreatedThroughForge { get; set; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern SovereignBlade();

	public override extern void AfterTransformedFrom();

	public override extern Task AfterCardChangedPiles(CardModel card, PileType oldPileType, AbstractModel? source);

	public extern void AddDamage(decimal amount);

	public extern void SetRepeats(decimal amount);

	public static extern NSovereignBladeVfx? GetVfxNode(Player player, CardModel card);
}
