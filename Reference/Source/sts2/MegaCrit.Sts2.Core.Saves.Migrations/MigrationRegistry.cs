using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class MigrationRegistry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Dictionary<Type, List<IMigration>> Migrations
	{
		[CompilerGenerated]
		get;
	}

	public extern void RegisterAllMigrations(MigrationManager manager);

	public extern MigrationRegistry();
}
