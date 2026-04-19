using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;

public class LoadRunLobby
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern INetGameService NetService
	{
		[CompilerGenerated]
		get;
	}

	public extern ILoadRunLobbyListener LobbyListener
	{
		[CompilerGenerated]
		get;
	}

	public extern PeerInputSynchronizer InputSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern SerializableRun Run
	{
		[CompilerGenerated]
		get;
	}

	public extern HashSet<ulong> ConnectedPlayerIds
	{
		[CompilerGenerated]
		get;
	}

	public extern GameMode GameMode { get; }

	public extern int HandshakeTimeout
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern LoadRunLobby(INetGameService netService, ILoadRunLobbyListener lobbyListener, SerializableRun runSave);

	public extern LoadRunLobby(INetGameService netService, ILoadRunLobbyListener lobbyListener, ClientLoadJoinResponseMessage message);

	public extern void CleanUp(bool disconnectSession);

	public extern void AddLocalHostPlayer();

	public extern void SetReady(bool ready);

	public extern bool IsPlayerReady(ulong playerId);
}
