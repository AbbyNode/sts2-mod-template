using Godot;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

public static class PlayerFullscreenHealVfx
{
	public static extern void Play(Player player, decimal healAmount, Control? vfxContainer);
}
