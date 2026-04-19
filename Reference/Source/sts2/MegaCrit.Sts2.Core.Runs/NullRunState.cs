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
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Runs;

public class NullRunState : IRunState, ICardScope, IPlayerCollection
{
	public static extern NullRunState Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<Player> Players { get; }

	public extern IReadOnlyList<ActModel> Acts { get; }

	public extern int CurrentActIndex { get; set; }

	public extern ActModel Act { get; }

	public extern ActMap Map { get; set; }

	public extern MapCoord? CurrentMapCoord { get; }

	public extern MapPoint? CurrentMapPoint { get; }

	public extern RunLocation CurrentLocation { get; }

	public extern int ActFloor { get; set; }

	public extern int TotalFloor { get; }

	public extern IReadOnlyList<ModifierModel> Modifiers { get; }

	public extern MultiplayerScalingModel? MultiplayerScalingModel { get; }

	public extern IReadOnlyList<IReadOnlyList<MapPointHistoryEntry>> MapPointHistory { get; }

	public extern MapPointHistoryEntry? CurrentMapPointHistoryEntry { get; }

	public extern int CurrentRoomCount { get; }

	public extern AbstractRoom? CurrentRoom { get; }

	public extern AbstractRoom? BaseRoom { get; }

	public extern bool IsGameOver { get; }

	public extern int AscensionLevel { get; }

	public extern RunRngSet Rng { get; }

	public extern RunOddsSet Odds { get; }

	public extern RelicGrabBag SharedRelicGrabBag { get; }

	public extern UnlockState UnlockState { get; }

	public extern ExtraRunFields ExtraFields { get; }

	public extern Player? GetPlayer(ulong netId);

	public extern int GetPlayerSlotIndex(Player player);

	public extern T CreateCard<T>(Player owner) where T : CardModel;

	public extern CardModel CreateCard(CardModel canonicalCard, Player owner);

	public extern CardModel CloneCard(CardModel mutableCard);

	public extern bool ContainsCard(CardModel card);

	public extern void AddCard(CardModel mutableCard, Player owner);

	public extern void RemoveCard(CardModel card);

	public extern CardModel LoadCard(SerializableCard serializableCard, Player owner);

	public extern void AppendToMapPointHistory(MapPointType mapPointType, RoomType initialRoomType, ModelId? modelId);

	public extern MapPointHistoryEntry? GetHistoryEntryFor(RunLocation location);

	public extern IEnumerable<AbstractModel> IterateHookListeners(CombatState? childCombatState);
}
