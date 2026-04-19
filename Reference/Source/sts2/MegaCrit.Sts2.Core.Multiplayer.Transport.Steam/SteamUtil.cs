using MegaCrit.Sts2.Core.Logging;
using Steamworks;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.Steam;

public static class SteamUtil
{
	public const uint handshakeMagicBytes = 2204332656u;

	public static extern NetTransferMode ModeFromFlags(int flags);

	public static extern int FlagsFromMode(NetTransferMode mode);

	public static extern SteamNetworkingIdentity ToNetId(this CSteamID id);

	public static extern SteamNetworkingIdentity ToNetId64(this ulong id);

	public static extern void ProcessMessages(HSteamNetConnection conn, INetHandler handler, Logger logger);
}
