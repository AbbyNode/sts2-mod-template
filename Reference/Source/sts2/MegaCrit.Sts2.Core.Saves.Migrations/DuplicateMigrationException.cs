namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class DuplicateMigrationException : InvalidMigrationPathException
{
	public extern DuplicateMigrationException(string message);
}
