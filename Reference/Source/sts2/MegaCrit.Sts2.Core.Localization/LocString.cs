using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Localization;

[DefaultMember("Item")]
public class LocString : IComparable<LocString>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("table")]
	public extern string LocTable { get; }

	[JsonPropertyName("key")]
	public extern string LocEntryKey { get; }

	[JsonIgnore]
	public extern bool IsEmpty { get; }

	[JsonIgnore]
	public extern IReadOnlyDictionary<string, object> Variables { get; }

	public extern LocString(string locTable, string locEntryKey);

	public static extern bool Exists(string table, string key);

	public static extern LocString? GetIfExists(string table, string key);

	public extern string GetFormattedText();

	public extern string GetRawText();

	public extern bool Exists();

	public static extern bool IsNullOrWhitespace(LocString? locString);

	public static extern void SubscribeToLocaleChange(LocManager.LocaleChangeCallback callback);

	public static extern void UnsubscribeToLocaleChange(LocManager.LocaleChangeCallback callback);

	public extern void Add(DynamicVar dynamicVar);

	public extern void Add(string name, decimal variable);

	public extern void Add(string name, bool variable);

	public extern void Add(string name, string variable);

	public extern void Add(string name, IList<string> variable);

	public extern void Add(string name, LocString variable);

	public extern void AddObj(string name, object variable);

	public static extern LocString KeyPathToLocString(string keyPath);

	public extern void AddVariablesFrom(LocString smartDescription);

	public static extern LocString GetRandomWithPrefix(string table, string keyPrefix, Rng? rng = null);

	public extern int CompareTo(LocString? other);
}
