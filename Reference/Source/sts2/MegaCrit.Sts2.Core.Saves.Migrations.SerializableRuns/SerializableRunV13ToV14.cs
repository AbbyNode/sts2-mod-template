namespace MegaCrit.Sts2.Core.Saves.Migrations.SerializableRuns;

[Migration(typeof(SerializableRun), 13, 14)]
public class SerializableRunV13ToV14 : MigrationBase<SerializableRun>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern SerializableRunV13ToV14();
}
