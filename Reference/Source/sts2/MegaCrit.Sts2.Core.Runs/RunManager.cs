using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Ascension;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Replay;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs.History;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.MapDrawing;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class RunManager : IRunLobbyListener
{
	public Action? debugAfterCombatRewardsOverride;

	public static extern RunManager Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern AscensionManager AscensionManager
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldSave
	{
		[CompilerGenerated]
		get;
	}

	public extern DateTimeOffset? DailyTime
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsInProgress { get; }

	public extern bool IsCleaningUp
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ForceDiscoveryOrderModifications
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsGameOver { get; }

	public extern bool IsAbandoned
	{
		[CompilerGenerated]
		get;
	}

	public extern RunHistory? History
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern INetGameService NetService
	{
		[CompilerGenerated]
		get;
	}

	public extern ChecksumTracker ChecksumTracker
	{
		[CompilerGenerated]
		get;
	}

	public extern RunLocationTargetedMessageBuffer RunLocationTargetedBuffer
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatReplayWriter CombatReplayWriter
	{
		[CompilerGenerated]
		get;
	}

	public extern RunLobby? RunLobby
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatStateSynchronizer CombatStateSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern MapSelectionSynchronizer MapSelectionSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern ActChangeSynchronizer ActChangeSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerChoiceSynchronizer PlayerChoiceSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern EventSynchronizer EventSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern RewardSynchronizer RewardSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern RestSiteSynchronizer RestSiteSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern OneOffSynchronizer OneOffSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern TreasureRoomRelicSynchronizer TreasureRoomRelicSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern FlavorSynchronizer FlavorSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern PeerInputSynchronizer InputSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern HoveredModelTracker HoveredModelTracker
	{
		[CompilerGenerated]
		get;
	}

	public extern ActionQueueSet ActionQueueSet
	{
		[CompilerGenerated]
		get;
	}

	public extern ActionExecutor ActionExecutor
	{
		[CompilerGenerated]
		get;
	}

	public extern ActionQueueSynchronizer ActionQueueSynchronizer
	{
		[CompilerGenerated]
		get;
	}

	public extern long WinTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern long RunTime { get; }

	public extern bool IsSinglePlayerOrFakeMultiplayer { get; }

	public extern SerializableMapDrawings? MapDrawingsToLoad
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern Dictionary<int, SerializableActMap>? SavedMapsToLoad
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool ShouldIgnoreUnlocks { get; }

	public extern event Action<RunState>? RunStarted;

	public extern event Action? RoomEntered;

	public extern event Action? RoomExited;

	public extern event Action? ActEntered;

	public extern void SetUpNewSinglePlayer(RunState state, bool shouldSave, DateTimeOffset? dailyTime = null);

	public extern void SetUpNewMultiPlayer(RunState state, StartRunLobby lobby, bool shouldSave, DateTimeOffset? dailyTime = null);

	public extern void SetUpSavedSinglePlayer(RunState state, SerializableRun save);

	public extern void SetUpSavedMultiPlayer(RunState state, LoadRunLobby lobby);

	public extern void SetUpReplay(RunState state, CombatReplay replay);

	public extern void SetUpTest(RunState state, INetGameService gameService, bool disableCombatStateSync = true, bool shouldSave = false);

	public extern void InitializeRunLobby(INetGameService netService, RunState state);

	public static extern SerializableRun CanonicalizeSave(SerializableRun save, ulong localPlayerId);

	public static extern HashSet<RoomType> BuildRoomTypeBlacklist(MapPointHistoryEntry? previousMapPointEntry, IReadOnlyCollection<MapPoint> nextMapPoints);

	public extern SerializableRun ToSave(AbstractRoom? preFinishedRoom);

	public extern RunState Launch();

	[AsyncStateMachine(typeof(_003CFinalizeStartingRelics_003Ed__173))]
	public extern Task FinalizeStartingRelics();

	public extern void GenerateRooms();

	public extern bool ShouldApplyTutorialModifications();

	[AsyncStateMachine(typeof(_003CGenerateMap_003Ed__176))]
	public extern Task GenerateMap();

	public extern Task EnterMapCoord(MapCoord coord);

	[AsyncStateMachine(typeof(_003CLoadIntoLatestMapCoord_003Ed__178))]
	public extern Task LoadIntoLatestMapCoord(AbstractRoom? preFinishedRoom);

	[AsyncStateMachine(typeof(_003CEnterMapPointInternal_003Ed__180))]
	public extern Task EnterMapPointInternal(int actFloor, MapPointType pointType, MapCoord? coord, AbstractRoom? preFinishedRoom, bool saveGame);

	[AsyncStateMachine(typeof(_003CEnterMapCoordDebug_003Ed__186))]
	public extern Task EnterMapCoordDebug(MapCoord coord, RoomType roomType, MapPointType pointType = MapPointType.Unassigned, AbstractModel? model = null, bool showTransition = true);

	[AsyncStateMachine(typeof(_003CEnterRoomDebug_003Ed__187))]
	public extern Task<AbstractRoom> EnterRoomDebug(RoomType roomType, MapPointType pointType = MapPointType.Unassigned, AbstractModel? model = null, bool showTransition = true);

	[AsyncStateMachine(typeof(_003CEnterRoom_003Ed__191))]
	public extern Task EnterRoom(AbstractRoom room);

	[AsyncStateMachine(typeof(_003CEnterRoomWithoutExitingCurrentRoom_003Ed__192))]
	public extern Task EnterRoomWithoutExitingCurrentRoom(AbstractRoom room, bool fadeToBlack);

	[AsyncStateMachine(typeof(_003CEnterNextAct_003Ed__193))]
	public extern Task EnterNextAct();

	[AsyncStateMachine(typeof(_003CEnterAct_003Ed__195))]
	public extern Task EnterAct(int currentActIndex, bool doTransition = true);

	[AsyncStateMachine(typeof(_003CSetActInternal_003Ed__196))]
	public extern Task SetActInternal(int actIndex);

	[AsyncStateMachine(typeof(_003CProceedFromTerminalRewardsScreen_003Ed__198))]
	public extern Task ProceedFromTerminalRewardsScreen();

	public extern void Abandon();

	extern void IRunLobbyListener.RunAbandoned();

	public extern void WriteReplay(bool stopRecording);

	public extern void CleanUp(bool graceful = true);

	public extern SerializableRun OnEnded(bool isVictory);

	public extern bool HasAscension(AscensionLevel level);

	public extern void ApplyAscensionEffects(Player player);

	public extern ClientRejoinResponseMessage GetRejoinMessage();

	public extern void LocalPlayerDisconnected(NetErrorInfo info);

	public extern string? GetLocalCharacterEnergyIconPrefix();

	public extern RunState? DebugOnlyGetState();
}
