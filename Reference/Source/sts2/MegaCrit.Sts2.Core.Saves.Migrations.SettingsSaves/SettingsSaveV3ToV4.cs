namespace MegaCrit.Sts2.Core.Saves.Migrations.SettingsSaves;

[Migration(typeof(SettingsSave), 3, 4)]
public class SettingsSaveV3ToV4 : MigrationBase<SettingsSave>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern SettingsSaveV3ToV4();
}
