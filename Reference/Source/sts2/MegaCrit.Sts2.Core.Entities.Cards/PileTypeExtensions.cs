using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.Cards;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public static class PileTypeExtensions
{
	public static extern CardPile GetPile(this PileType pileType, Player player);

	public static extern bool IsCombatPile(this PileType pileType);

	public static extern Vector2 GetTargetPosition(this PileType pileType, NCard? node);
}
