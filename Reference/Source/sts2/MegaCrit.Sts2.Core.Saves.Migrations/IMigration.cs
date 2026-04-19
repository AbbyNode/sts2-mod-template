using System;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public interface IMigration
{
	int FromVersion { get; }

	int ToVersion { get; }

	Type SaveType { get; }

	MigratingData Migrate(MigratingData saveData);
}
public interface IMigration<T> : IMigration where T : ISaveSchema
{
}
