using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Saves.Migrations.RunHistories;

[Migration(typeof(RunHistory), 7, 8)]
public class RunHistoryV7ToV8 : MigrationBase<RunHistory>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern RunHistoryV7ToV8();
}
