using Godot;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.ENet;

public static class ENetConnectionExtension
{
	public static extern bool TryService(this ENetConnection connection, out ENetServiceData? output);
}
