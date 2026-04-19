namespace MegaCrit.Sts2.Core.Saves;

public static class AccountScopeUserDataMigrator
{
	public static extern void MigrateToUserScopedDirectories();

	public static extern void ArchiveLegacyData();
}
