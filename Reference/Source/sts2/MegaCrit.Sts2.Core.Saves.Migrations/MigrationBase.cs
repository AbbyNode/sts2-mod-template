using System;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public abstract class MigrationBase<T> : IMigration<T>, IMigration where T : ISaveSchema
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int FromVersion { get; }

	public extern int ToVersion { get; }

	public extern Type SaveType { get; }

	protected extern MigrationBase();

	public extern MigratingData Migrate(MigratingData saveData);

	protected abstract void ApplyMigration(MigratingData saveData);
}
