using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Platform.Steam;

public static class SteamDisconnectionReasonExtensions
{
	public static extern SteamDisconnectionReason ToSteam(this NetError reason);

	public static extern NetError ToApp(this SteamDisconnectionReason steamReason);
}
