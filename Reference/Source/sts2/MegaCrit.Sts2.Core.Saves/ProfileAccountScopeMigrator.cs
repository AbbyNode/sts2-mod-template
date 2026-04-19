namespace MegaCrit.Sts2.Core.Saves;

public static class ProfileAccountScopeMigrator
{
	public static extern void MigrateToProfileScopedDirectories();

	public static extern void ArchiveLegacyData();
}
