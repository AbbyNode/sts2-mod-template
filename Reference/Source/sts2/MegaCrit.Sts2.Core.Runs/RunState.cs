using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Singleton;
using MegaCrit.Sts2.Core.Odds;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs.History;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Runs;

public class RunState : IRunState, ICardScope, IPlayerCollection
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<Player> Players { get; }

	public extern IReadOnlyList<ActModel> Acts
	{
		[CompilerGenerated]
		get;
	}

	public extern int CurrentActIndex { get; set; }

	public extern ActModel Act { get; }

	public extern ActMap Map
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern IReadOnlyList<MapCoord> VisitedMapCoords { get; }

	public extern MapCoord? CurrentMapCoord { get; }

	public extern MapPoint? CurrentMapPoint { get; }

	public extern RunLocation CurrentLocation { get; }

	public extern int ActFloor
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int TotalFloor { get; }

	public extern IReadOnlyList<IReadOnlyList<MapPointHistoryEntry>> MapPointHistory { get; }

	public extern MapPointHistoryEntry? CurrentMapPointHistoryEntry { get; }

	public extern int CurrentRoomCount { get; }

	public extern AbstractRoom? CurrentRoom { get; }

	public extern AbstractRoom? BaseRoom { get; }

	public extern bool IsGameOver { get; }

	public extern int AscensionLevel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern RunRngSet Rng
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern RunOddsSet Odds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern RelicGrabBag SharedRelicGrabBag
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern UnlockState UnlockState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern IReadOnlySet<ModelId> VisitedEventIds { get; }

	public extern IReadOnlyList<ModifierModel> Modifiers
	{
		[CompilerGenerated]
		get;
	}

	public extern ExtraRunFields ExtraFields
	{
		[CompilerGenerated]
		get;
	}

	public extern MultiplayerScalingModel MultiplayerScalingModel
	{
		[CompilerGenerated]
		get;
	}

	public static extern RunState CreateForNewRun(IReadOnlyList<Player> players, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, int ascensionLevel, string seed);

	public static extern RunState FromSerializable(SerializableRun save);

	public static extern RunState CreateForTest(IReadOnlyList<Player>? players = null, IReadOnlyList<ActModel>? acts = null, IReadOnlyList<ModifierModel>? modifiers = null, int ascensionLevel = 0, string? seed = null);

	public extern int GetPlayerSlotIndex(Player player);

	public extern int GetPlayerSlotIndex(ulong netId);

	public extern Player? GetPlayer(ulong netId);

	public extern T CreateCard<T>(Player owner) where T : CardModel;

	public extern CardModel CreateCard(CardModel canonicalCard, Player owner);

	public extern CardModel CloneCard(CardModel mutableCard);

	public extern void AddCard(CardModel card, Player owner);

	public extern void RemoveCard(CardModel card);

	public extern bool ContainsCard(CardModel card);

	public extern CardModel LoadCard(SerializableCard serializableCard, Player owner);

	public extern bool AddVisitedMapCoord(MapCoord coord);

	public extern AbstractRoom PopCurrentRoom();

	public extern void PushRoom(AbstractRoom room);

	public extern void AddVisitedEvent(EventModel eventModel);

	public extern void AppendToMapPointHistory(MapPointType mapPointType, RoomType initialRoomType, ModelId? roomModelId);

	public extern MapPointHistoryEntry? GetHistoryEntryFor(RunLocation location);

	[IteratorStateMachine(typeof(_003CIterateHookListeners_003Ed__104))]
	public extern IEnumerable<AbstractModel> IterateHookListeners(CombatState? childCombatState);

	public extern void AddPlayerDebug(Player player, int index);

	public extern void SetActDebug(ActModel act);

	public extern void ClearVisitedMapCoordsDebug();

	public extern void AddModifierDebug(ModifierModel modifier);
}
