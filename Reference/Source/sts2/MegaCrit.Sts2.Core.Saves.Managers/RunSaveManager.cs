using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Migrations;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class RunSaveManager
{
	public const string runSaveFileName = "current_run.save";

	public const string multiplayerRunSaveFileName = "current_run_mp.save";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool HasRunSave { get; }

	public extern bool HasMultiplayerRunSave { get; }

	public extern int SchemaVersion { get; }

	public extern event Action? Saved;

	public extern RunSaveManager(int profileId, ISaveStore saveStore, MigrationManager migrationManager, bool forceSynchronous = false);

	public extern RunSaveManager(ISaveStore saveStore, MigrationManager migrationManager, IProfileIdProvider profileIdProvider, bool forceSynchronous = false);

	[AsyncStateMachine(typeof(_003CSaveRun_003Ed__21))]
	public extern Task SaveRun(AbstractRoom? preFinishedRoom);

	public extern ReadSaveResult<SerializableRun> LoadRunSave();

	public extern ReadSaveResult<SerializableRun> LoadMultiplayerRunSave();

	public extern ReadSaveResult<SerializableRun> LoadAndCanonicalizeMultiplayerRunSave(ulong localPlayerId);

	public extern void DeleteCurrentRun();

	public extern void DeleteCurrentMultiplayerRun();

	public extern void RenameBrokenMultiplayerRunSave(ReadSaveStatus status);

	public static extern string GetRunSavePath(int profileId, string fileName);
}
