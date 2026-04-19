using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves.Migrations;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class SettingsSaveManager
{
	public const string settingsSaveFileName = "settings.save";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern SettingsSave Settings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SettingsSaveManager(ISaveStore saveStore, MigrationManager migrationManager);

	public extern void SaveSettings();

	public extern ReadSaveResult<SettingsSave> LoadSettings();
}
