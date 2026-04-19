using System.Text.Json.Nodes;

namespace MegaCrit.Sts2.Core.Saves.Migrations.Shared;

public static class SharedMigrationHelper
{
	public static extern void MigrateMapPointHistoryRooms(JsonNode? jsonNode);

	public static extern void RecursiveRemoveSchema(JsonNode node, int depth = 0);

	public static extern void MigrateMapPointHistoryCardChoices(JsonNode? jsonNode);
}
