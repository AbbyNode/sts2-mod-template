using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Migrations;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class ProgressSaveManager
{
	public const string fileName = "progress.save";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ProgressState Progress
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern ProgressSaveManager(int profileId, ISaveStore saveStore, MigrationManager migrationManager);

	public extern ProgressSaveManager(ISaveStore saveStore, MigrationManager migrationManager, IProfileIdProvider profileIdProvider);

	public static extern string GetProgressPathForProfile(int profileId);

	public extern void SaveProgress();

	public extern ReadSaveResult<SerializableProgress> LoadProgress();

	public extern UnlockState GenerateUnlockState();

	public extern void MarkPotionAsSeen(PotionModel potion);

	public extern void MarkCardAsSeen(CardModel card);

	public extern void MarkRelicAsSeen(RelicModel relic);

	public extern void UpdateWithRunData(SerializableRun serializableRun, bool victory);

	public extern IEnumerable<SerializableEpoch> GetRevealableEpochs();

	public extern void UpdateAfterCombatWon(Player localPlayer, CombatRoom room);

	public extern bool SeenFtue(string ftueKey);

	public extern void MarkFtueAsComplete(string ftueId);

	public extern void SetFtuesEnabled(bool enabled);

	public extern void ResetFtues();
}
