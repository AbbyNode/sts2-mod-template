namespace MegaCrit.Sts2.Core.Saves.Migrations.PrefsSaves;

[Migration(typeof(PrefsSave), 1, 2)]
public class PrefsSaveV1ToV2 : MigrationBase<PrefsSave>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern PrefsSaveV1ToV2();
}
