using Godot;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public static class NetScreenTypeExtensions
{
	public static extern Texture2D? GetLocationIcon(this NetScreenType screenType);
}
