using System;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class MigrationException : Exception
{
	public extern MigrationException(string message);

	public extern MigrationException(string message, Exception innerException);
}
