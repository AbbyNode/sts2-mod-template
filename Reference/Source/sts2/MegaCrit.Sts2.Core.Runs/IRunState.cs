using System.Collections.Generic;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
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

public interface IRunState : ICardScope, IPlayerCollection
{
	IReadOnlyList<ActModel> Acts { get; }

	int CurrentActIndex { get; set; }

	ActModel Act { get; }

	ActMap Map { get; set; }

	MapCoord? CurrentMapCoord { get; }

	MapPoint? CurrentMapPoint { get; }

	RunLocation CurrentLocation { get; }

	int ActFloor { get; set; }

	int TotalFloor { get; }

	int CurrentRoomCount { get; }

	AbstractRoom? CurrentRoom { get; }

	AbstractRoom? BaseRoom { get; }

	bool IsGameOver { get; }

	int AscensionLevel { get; }

	RunRngSet Rng { get; }

	RunOddsSet Odds { get; }

	RelicGrabBag SharedRelicGrabBag { get; }

	UnlockState UnlockState { get; }

	IReadOnlyList<ModifierModel> Modifiers { get; }

	MultiplayerScalingModel? MultiplayerScalingModel { get; }

	IReadOnlyList<IReadOnlyList<MapPointHistoryEntry>> MapPointHistory { get; }

	MapPointHistoryEntry? CurrentMapPointHistoryEntry { get; }

	ExtraRunFields ExtraFields { get; }

	CardMultiplayerConstraint CardMultiplayerConstraint { get; }

	bool ContainsCard(CardModel card);

	CardModel LoadCard(SerializableCard serializableCard, Player owner);

	void AppendToMapPointHistory(MapPointType mapPointType, RoomType initialRoomType, ModelId? modelId);

	MapPointHistoryEntry? GetHistoryEntryFor(RunLocation location);

	IEnumerable<AbstractModel> IterateHookListeners(CombatState? childCombatState);

	static IRunState GetFrom(IEnumerable<Creature> creatures);
}
