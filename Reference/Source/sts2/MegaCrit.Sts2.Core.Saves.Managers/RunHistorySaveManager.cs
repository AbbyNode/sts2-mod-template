using System.Collections.Generic;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Migrations;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class RunHistorySaveManager
{
	public const int maxCloudBytes = 5242880;

	public const int maxCloudFileCount = 100;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern RunHistorySaveManager(int profileId, ISaveStore saveStore, MigrationManager migrationManager);

	public extern RunHistorySaveManager(ISaveStore saveStore, MigrationManager migrationManager, IProfileIdProvider profileIdProvider);

	public extern void CreateRunHistoryDirectory();

	public static extern string GetHistoryPath(int profileId);

	public extern void SaveHistory(RunHistory history);

	public extern int GetHistoryCount();

	public extern ReadSaveResult<RunHistory> LoadHistory(string fileName);

	public extern List<string> LoadAllRunHistoryNames();
}
