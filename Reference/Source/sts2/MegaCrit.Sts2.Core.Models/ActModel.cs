using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Achievements;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models;

public abstract class ActModel : AbstractModel
{
	protected RoomSet _rooms;

	public extern LocString Title { get; }

	protected extern string FilePathIdentifier { get; }

	public extern string RestSiteBackgroundPath { get; }

	public extern string MapTopBgPath { get; }

	public extern Texture2D MapTopBg { get; }

	public extern string MapMidBgPath { get; }

	public extern Texture2D MapMidBg { get; }

	public extern string MapBotBgPath { get; }

	public extern Texture2D MapBotBg { get; }

	public abstract Color MapTraveledColor { get; }

	public abstract Color MapUntraveledColor { get; }

	public abstract Color MapBgColor { get; }

	public extern IEnumerable<string> AssetPaths { get; }

	public abstract string[] BgMusicOptions { get; }

	public abstract string[] MusicBankPaths { get; }

	public abstract string AmbientSfx { get; }

	protected virtual extern int NumberOfWeakEncounters { get; }

	protected abstract int BaseNumberOfRooms { get; }

	public extern IEnumerable<EncounterModel> AllEncounters { get; }

	public extern IEnumerable<EncounterModel> AllWeakEncounters { get; }

	public extern IEnumerable<EncounterModel> AllRegularEncounters { get; }

	public extern IEnumerable<EncounterModel> AllEliteEncounters { get; }

	public extern IEnumerable<EncounterModel> AllBossEncounters { get; }

	public extern IEnumerable<MonsterModel> AllMonsters { get; }

	public extern Achievement DefeatedAllEnemiesAchievement { get; }

	public virtual extern string ChestSpineResourcePath { get; }

	public abstract string ChestSpineSkinNameNormal { get; }

	public abstract string ChestSpineSkinNameStroke { get; }

	public virtual extern MegaSkeletonDataResource ChestSpineResource { get; }

	public abstract string ChestOpenSfx { get; }

	public abstract IEnumerable<EncounterModel> BossDiscoveryOrder { get; }

	public abstract IEnumerable<AncientEventModel> AllAncients { get; }

	public abstract IEnumerable<EventModel> AllEvents { get; }

	public extern ActModel CanonicalInstance { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern EncounterModel BossEncounter { get; }

	public extern EncounterModel? SecondBossEncounter { get; }

	public extern bool HasSecondBoss { get; }

	public extern AncientEventModel Ancient { get; }

	public extern string BackgroundScenePath { get; }

	public extern Control CreateRestSiteBackground();

	public extern int GetNumberOfRooms(bool isMultiplayer);

	public extern int GetNumberOfFloors(bool isMultiplayer);

	public abstract IEnumerable<EncounterModel> GenerateAllEncounters();

	protected override extern void DeepCloneFields();

	public abstract IEnumerable<AncientEventModel> GetUnlockedAncients(UnlockState state);

	protected extern string GetFullLayerPath(string layerName);

	public extern void SetSharedAncientSubset(List<AncientEventModel> sharedAncientSubset);

	public extern IEnumerable<string> GetAllBackgroundLayerPaths();

	public extern void GenerateRooms(Rng rng, UnlockState unlockState, bool isMultiplayer = false);

	public extern void ValidateRoomsAfterLoad(Rng rng);

	public extern void ApplyDiscoveryOrderModifications(UnlockState unlockState);

	protected abstract void ApplyActDiscoveryOrderModifications(UnlockState unlockState);

	public extern EventModel PullAncient();

	public extern EventModel PullNextEvent(RunState runState);

	public extern EncounterModel PullNextEncounter(RoomType roomType);

	public extern void MarkRoomVisited(RoomType roomType);

	public extern BackgroundAssets GenerateBackgroundAssets(Rng rng);

	public extern void SetBossEncounter(EncounterModel encounter);

	public extern void SetSecondBossEncounter(EncounterModel? encounter);

	public extern void RemoveEventFromSet(EventModel eventModel);

	public extern ActModel ToMutable();

	public extern SerializableActModel ToSave();

	public static extern ActModel FromSave(SerializableActModel save);

	public abstract MapPointTypeCounts GetMapPointTypes(Rng mapRng);

	public extern ActMap CreateMap(RunState runState, bool replaceTreasureWithElites);

	public static extern IEnumerable<ActModel> GetRandomList(string seed, UnlockState unlockState, bool isMultiplayer);

	public static extern IReadOnlyList<ActModel> GetDefaultList();

	protected extern ActModel();
}
