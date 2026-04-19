namespace MegaCrit.Sts2.Core.Saves;

public static class MigrationUtil
{
	public static extern bool MigrateDirectory(string directoryName, string legacyBasePath, string newBasePath);

	public static extern bool MigrateFile(string fileName, string legacyBasePath, string newBasePath);

	public static extern void CopyDirectoryRecursively(string sourceDir, string targetDir);

	public static extern void ArchiveLegacyDirectory(string directoryPath, string archivePath);

	public static extern void ArchiveLegacyFile(string filePath, string archivePath);
}
