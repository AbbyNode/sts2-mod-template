using System;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class InvalidMigrationPathException : Exception
{
	protected extern InvalidMigrationPathException(string message);
}
