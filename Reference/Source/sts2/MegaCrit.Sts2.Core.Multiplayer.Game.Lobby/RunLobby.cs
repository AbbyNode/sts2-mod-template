using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;

public class RunLobby
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyCollection<ulong> ConnectedPlayerIds { get; }

	public extern GameMode GameMode
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action<ulong>? PlayerRejoined;

	public extern event Action<ulong>? RemotePlayerDisconnected;

	public extern event Action? LocalPlayerDisconnected;

	public extern RunLobby(GameMode gameMode, INetGameService netService, IRunLobbyListener lobbyListener, IPlayerCollection playerCollection, IEnumerable<ulong> connectedPlayerIds);

	public extern void Dispose();

	public extern void AbandonRun();
}
