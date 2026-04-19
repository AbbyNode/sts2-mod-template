using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves.Migrations;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class PrefsSaveManager
{
	public const string fileName = "prefs.save";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PrefsSave Prefs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern PrefsSaveManager(int profileId, ISaveStore saveStore, MigrationManager migrationManager);

	public extern PrefsSaveManager(ISaveStore saveStore, MigrationManager migrationManager, IProfileIdProvider profileIdProvider);

	public static extern string GetPrefsPath(int profileId);

	public extern void SavePrefs();

	public extern ReadSaveResult<PrefsSave> LoadPrefs();
}
