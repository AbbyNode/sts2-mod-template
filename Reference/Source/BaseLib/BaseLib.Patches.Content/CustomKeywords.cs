using System.Collections.Generic;

namespace BaseLib.Patches.Content;

public static class CustomKeywords
{
	public readonly struct KeywordInfo(string key)
	{
		public readonly string Key = key;

		public required AutoKeywordPosition AutoPosition { get; init; } = AutoKeywordPosition.None;

		public required bool RichKeyword { get; init; } = false;

		public static implicit operator string(KeywordInfo info)
		{
			return info.Key;
		}
	}

	public static readonly Dictionary<int, KeywordInfo> KeywordIDs = new Dictionary<int, KeywordInfo>();
}
