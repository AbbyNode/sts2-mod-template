using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Localization;

public class LocTable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IEnumerable<string> Keys { get; }

	public extern LocTable(string name, Dictionary<string, string> data, LocTable? fallback = null);

	public extern void MergeWith(Dictionary<string, string> otherTable);

	public extern LocString GetLocString(string key);

	public extern string GetRawText(string key);

	public extern IReadOnlyList<LocString> GetLocStringsWithPrefix(string keyPrefix);

	public extern bool IsLocalKey(string key);

	public extern bool HasEntry(string key);
}
