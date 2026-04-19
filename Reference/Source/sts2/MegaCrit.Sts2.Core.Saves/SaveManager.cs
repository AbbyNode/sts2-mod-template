using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Timeline;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Saves;

public class SaveManager : IProfileIdProvider
{
	public const int totalAgnosticUnlocks = 18;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern SaveManager Instance { get; }

	public extern SettingsSave SettingsSave { get; }

	public extern PrefsSave PrefsSave { get; }

	public extern ProgressState Progress { get; set; }

	public extern bool HasRunSave { get; }

	public extern bool HasMultiplayerRunSave { get; }

	public extern int CurrentProfileId { get; }

	public extern Task? CurrentRunSaveTask
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action? Saved;

	public extern event Action<int>? ProfileIdChanged;

	public static extern void MockInstanceForTesting(SaveManager saveManager);

	public static extern void ClearInstanceForTesting();

	public extern SaveManager(ISaveStore saveStore, bool forceSynchronous = false);

	public extern void InitProfileId(int? profileId = null);

	public extern int GetLatestSchemaVersion<T>();

	public extern string GetProfileScopedPath(string userData);

	public extern void SwitchProfileId(int profileId);

	public extern SaveBatchScope BeginSaveBatch();

	public extern void EndSaveBatch();

	[AsyncStateMachine(typeof(_003CSaveRun_003Ed__48))]
	public extern Task SaveRun(AbstractRoom? preFinishedRoom, bool saveProgress = true);

	public extern void UpdateProgressWithRunData(SerializableRun serializableRun, bool victory);

	public extern void UpdateProgressAfterCombatWon(Player localPlayer, CombatRoom combatRoom);

	public extern void DeleteCurrentRun();

	public extern void DeleteCurrentMultiplayerRun();

	public extern void DeleteProfile(int profileId);

	public extern void DeleteDirectoryRecursive(string directory);

	public extern void SaveSettings();

	public extern void SaveProfile();

	public extern ReadSaveResult<SettingsSave> InitSettingsDataForTest();

	public extern ReadSaveResult<PrefsSave> InitPrefsDataForTest();

	public extern ReadSaveResult<SettingsSave> InitSettingsData();

	public extern ReadSaveResult<PrefsSave> InitPrefsData();

	public extern ReadSaveResult<SerializableProgress> InitProgressData();

	[AsyncStateMachine(typeof(_003CSyncCloudToLocal_003Ed__63))]
	public extern Task SyncCloudToLocal();

	[AsyncStateMachine(typeof(_003CTryFirstTimeCloudSync_003Ed__68))]
	public extern Task<bool> TryFirstTimeCloudSync();

	public extern ReadSaveResult<SerializableRun> LoadRunSave();

	public extern ReadSaveResult<SerializableRun> LoadAndCanonicalizeMultiplayerRunSave(ulong localPlayerId);

	public extern void SaveRunHistory(RunHistory history);

	public extern int GetRunHistoryCount();

	public extern List<string> GetAllRunHistoryNames();

	public extern ReadSaveResult<RunHistory> LoadRunHistory(string fileName);

	public static extern string ToJson<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] T>(T obj) where T : ISaveSchema;

	public static extern ReadSaveResult<T> FromJson<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] T>(string json) where T : ISaveSchema, new();

	public extern bool SeenFtue(string ftueKey);

	public extern void SaveProgressFile();

	public extern UnlockState GenerateUnlockStateFromProgress();

	public extern void SavePrefsFile();

	public extern void MarkFtueAsComplete(string ftueId);

	public extern void SetFtuesEnabled(bool enabled);

	public extern void ResetFtues();

	public extern void MarkPotionAsSeen(PotionModel potion);

	public extern void MarkCardAsSeen(CardModel card);

	public extern void MarkRelicAsSeen(RelicModel relic);

	public extern bool IsRelicSeen(RelicModel relic);

	public extern void UnlockSlot(string epochId);

	public extern void ObtainEpoch(string epochId);

	public extern void ObtainEpochOverride(string epochId, EpochState state);

	public extern void RevealEpoch(string epochId, bool isDebug = false);

	public extern void ResetTimelineProgress();

	public extern bool IsEpochRevealed<T>() where T : EpochModel;

	public extern bool IsEpochRevealed(string id);

	public extern int GetTotalUnlockedCards();

	public static extern int GetUnlockableCardCount();

	public extern int GetTotalUnlockedRelics();

	public static extern int GetUnlockableRelicCount();

	public extern int GetTotalUnlockedPotions();

	public static extern int GetUnlockablePotionCount();

	public extern int GetAggregateAscensionProgress();

	public static extern int GetAggregateAscensionCount();

	public extern int GetTotalKills();

	public extern IEnumerable<SerializableEpoch> GetRevealableEpochs();

	public extern int GetDiscoveredEpochCount();

	public extern bool IsNeowDiscovered();

	public extern int GetUnlocksRemaining();

	public extern int GetCurrentScore();

	public extern string? IncrementUnlock();

	public extern bool IsCompendiumAvailable();
}
