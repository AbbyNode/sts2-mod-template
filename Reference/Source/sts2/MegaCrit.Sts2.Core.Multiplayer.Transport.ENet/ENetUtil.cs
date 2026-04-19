namespace MegaCrit.Sts2.Core.Multiplayer.Transport.ENet;

public static class ENetUtil
{
	public static extern NetTransferMode ModeFromFlags(int flags);

	public static extern int FlagsFromMode(NetTransferMode mode);
}
