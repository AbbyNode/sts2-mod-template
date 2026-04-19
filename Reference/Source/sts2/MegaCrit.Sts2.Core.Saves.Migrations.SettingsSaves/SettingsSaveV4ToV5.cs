namespace MegaCrit.Sts2.Core.Saves.Migrations.SettingsSaves;

[Migration(typeof(SettingsSave), 4, 5)]
public class SettingsSaveV4ToV5 : MigrationBase<SettingsSave>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern SettingsSaveV4ToV5();
}
