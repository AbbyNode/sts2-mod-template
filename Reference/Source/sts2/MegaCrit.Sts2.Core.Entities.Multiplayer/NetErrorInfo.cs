using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.Platform.Steam;
using Steamworks;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public readonly struct NetErrorInfo
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool SelfInitiated
	{
		[CompilerGenerated]
		get;
	}

	public extern NetErrorInfo(NetError reason, bool selfInitiated);

	public extern NetErrorInfo(ConnectionFailureReason reason, ConnectionFailureExtraInfo? extraInfo = null);

	public extern NetErrorInfo(SteamDisconnectionReason steamReason, string? debugReason, bool selfInitiated);

	public extern NetErrorInfo(EChatRoomEnterResponse lobbyEnterResponse);

	public extern NetErrorInfo(EResult lobbyCreationResult);

	public extern NetErrorInfo(Error error);

	public extern NetError GetReason();

	public extern string GetErrorString();

	public override extern string ToString();
}
