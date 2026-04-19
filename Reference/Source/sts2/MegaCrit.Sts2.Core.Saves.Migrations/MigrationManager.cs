using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class MigrationManager
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern MigrationManager(ISaveStore saveStore);

	public extern int GetLatestVersion<T>();

	public extern void RegisterMigration(IMigration migration);

	public extern IEnumerable<Type> GetRegisteredSaveTypes();

	public extern IEnumerable<IMigration> GetMigrationsForType(Type saveType);

	public extern T CreateNewSave<T>() where T : ISaveSchema, new();

	public extern ReadSaveResult<T> LoadSave<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] T>(string filePath) where T : ISaveSchema, new();
}
