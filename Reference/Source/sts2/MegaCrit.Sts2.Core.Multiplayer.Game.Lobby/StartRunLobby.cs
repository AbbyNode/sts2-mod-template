using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Daily;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;

public class StartRunLobby
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern INetGameService NetService
	{
		[CompilerGenerated]
		get;
	}

	public extern IStartRunLobbyListener LobbyListener
	{
		[CompilerGenerated]
		get;
	}

	public extern PeerInputSynchronizer InputSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern int MaxPlayers
	{
		[CompilerGenerated]
		get;
	}

	public extern int Ascension
	{
		[CompilerGenerated]
		get;
	}

	public extern int MaxAscension
	{
		[CompilerGenerated]
		get;
	}

	public extern string? Seed
	{
		[CompilerGenerated]
		get;
	}

	public extern TimeServerResult? DailyTime
	{
		[CompilerGenerated]
		get;
	}

	public extern GameMode GameMode
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<ModifierModel> Modifiers { get; }

	public extern int HandshakeTimeout
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string Act1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<LobbyPlayer> Players
	{
		[CompilerGenerated]
		get;
	}

	public extern LobbyPlayer LocalPlayer { get; }

	public extern event Action<LobbyPlayer>? PlayerConnected;

	public extern event Action<LobbyPlayer>? PlayerDisconnected;

	public extern StartRunLobby(GameMode gameMode, INetGameService netService, IStartRunLobbyListener lobbyListener, int maxPlayers);

	public extern StartRunLobby(GameMode gameMode, INetGameService netService, IStartRunLobbyListener lobbyListener, TimeServerResult timeServerResult, int maxPlayers);

	public extern void InitializeFromMessage(ClientLobbyJoinResponseMessage message);

	public extern void CleanUp(bool disconnectSession);

	public extern LobbyPlayer? AddLocalHostPlayer(UnlockState unlocks, int maxMultiplayerAscension);

	public extern LobbyPlayer? AddLocalHostPlayerInternal(SerializableUnlockState unlockState, int maxMultiplayerAscension);

	public extern void SetLocalCharacter(CharacterModel character);

	public extern void SetSeed(string? seed);

	public extern void SetModifiers(List<ModifierModel> modifiers);

	public extern void SetReady(bool ready);

	public extern bool IsAboutToBeginGame();

	public extern void SyncAscensionChange(int ascension);
}
