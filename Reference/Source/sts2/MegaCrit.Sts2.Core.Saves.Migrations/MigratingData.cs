using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

public class MigratingData
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern object? this[string key] { get; }

	public extern MigratingData(JsonDocument document);

	public extern MigratingData(string json);

	public extern MigratingData(JsonObject jsonObject);

	public extern T ToObject<T>() where T : new();

	public extern void Remove(string key);

	public extern void Rename(string oldKey, string newKey);

	public extern bool Has(string key);

	public extern T? GetAsOrNull<T>(string key) where T : struct;

	public extern T GetAs<T>(string key);

	public extern string GetString(string key);

	public extern bool GetBool(string key);

	public extern int GetInt(string key);

	public extern MigratingData GetObject(string key);

	public extern void Set<T>(string key, T value);

	public extern void SetObject(string key, MigratingData value);

	public extern List<MigratingData> GetList(string key);

	public extern JsonNode? GetRawNode(string key);

	public extern JsonObject GetRawNode();

	public extern void SetList<T>(string key, IEnumerable<T> items);
}
