using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Localization;

namespace BaseLib.Patches.Localization;

[HarmonyPatch(typeof(LocManager), "LoadTable")]
public static class SimpleLoc
{
	private static readonly HashSet<string> SimpleLocEnabled = new HashSet<string>();

	private static readonly Dictionary<string, string> SpecialVarDictionary = new Dictionary<string, string>
	{
		{ "D", "Damage" },
		{ "CD", "CalculatedDamage" },
		{ "B", "Block" },
		{ "CB", "CalculatedBlock" },
		{ "C", "Cards" },
		{ "E", "Energy" },
		{ "H", "Heal" }
	};

	/// <remarks>
	/// Pattern:<br />
	/// <code>\\*(.+?)(?:\\*|(\\s|\\b))</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match '*'.<br />
	/// ○ 1st capture group.<br />
	///     ○ Match a character other than '\n' lazily at least once.<br />
	/// ○ Match with 2 alternative expressions, atomically.<br />
	///     ○ Match '*'.<br />
	///     ○ 2nd capture group.<br />
	///         ○ Match with 2 alternative expressions, atomically.<br />
	///             ○ Match a whitespace character.<br />
	///             ○ Match if at a word boundary.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("\\*(.+?)(?:\\*|(\\s|\\b))")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex HighlightRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__HighlightRegex_1.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>({)([^:}.]+)([:}])</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ 1st capture group.<br />
	///     ○ Match '{'.<br />
	/// ○ 2nd capture group.<br />
	///     ○ Match a character in the set [^.:}] greedily at least once.<br />
	/// ○ 3rd capture group.<br />
	///     ○ Match a character in the set [:}].<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("({)([^:}.]+)([:}])")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex NormalVariableRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__NormalVariableRegex_2.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>!(.*?)!</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match '!'.<br />
	/// ○ 1st capture group.<br />
	///     ○ Match a character other than '\n' lazily any number of times.<br />
	/// ○ Match '!'.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("!(.*?)!")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex DiffVariableRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__DiffVariableRegex_3.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>@(.*?)@</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match '@'.<br />
	/// ○ 1st capture group.<br />
	///     ○ Match a character other than '\n' lazily any number of times.<br />
	/// ○ Match '@'.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("@(.*?)@")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex InverseVariableRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__InverseVariableRegex_4.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>(?:(?:-(.+?)-)|(?:\\+(.+?)\\+))(?:\\+(.+?)\\+)?</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match with 2 alternative expressions.<br />
	///     ○ Match a sequence of expressions.<br />
	///         ○ Match '-'.<br />
	///         ○ 1st capture group.<br />
	///             ○ Match a character other than '\n' lazily at least once.<br />
	///         ○ Match '-'.<br />
	///     ○ Match a sequence of expressions.<br />
	///         ○ Match '+'.<br />
	///         ○ 2nd capture group.<br />
	///             ○ Match a character other than '\n' lazily at least once.<br />
	///         ○ Match '+'.<br />
	/// ○ Optional (greedy).<br />
	///     ○ Match '+'.<br />
	///     ○ 3rd capture group.<br />
	///         ○ Match a character other than '\n' lazily at least once.<br />
	///     ○ Match '+'.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("(?:(?:-(.+?)-)|(?:\\+(.+?)\\+))(?:\\+(.+?)\\+)?")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex UpgradeSwapRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__UpgradeSwapRegex_5.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>({)([^{]+?)((?::.*)?}.*?)\\((.+?)\\)</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ 1st capture group.<br />
	///     ○ Match '{'.<br />
	/// ○ 2nd capture group.<br />
	///     ○ Match a character other than '{' lazily at least once.<br />
	/// ○ 3rd capture group.<br />
	///     ○ Optional (greedy).<br />
	///         ○ Match ':'.<br />
	///         ○ Match a character other than '\n' greedily any number of times.<br />
	///     ○ Match '}'.<br />
	///     ○ Match a character other than '\n' lazily any number of times.<br />
	/// ○ Match '('.<br />
	/// ○ 4th capture group.<br />
	///     ○ Match a character other than '\n' lazily at least once.<br />
	/// ○ Match ')'.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("({)([^{]+?)((?::.*)?}.*?)\\((.+?)\\)")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex PluralizeRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__PluralizeRegex_6.Instance;

	/// <remarks>
	/// Pattern:<br />
	/// <code>\\[(?:(E\\?)|(E+))\\]</code><br />
	/// Explanation:<br />
	/// <code>
	/// ○ Match '['.<br />
	/// ○ Match with 2 alternative expressions.<br />
	///     ○ 1st capture group.<br />
	///         ○ Match the string "E?".<br />
	///     ○ 2nd capture group.<br />
	///         ○ Match 'E' atomically at least once.<br />
	/// ○ Match ']'.<br />
	/// </code>
	/// </remarks>
	[GeneratedRegex("\\[(?:(E\\?)|(E+))\\]")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "9.0.14.6317")]
	private static Regex EnergyIconsRegex => _003CRegexGenerator_g_003EF2510F4315406E63A39BEC1503FA28868C36343733B7483E5396C61FEAF06DCCD__EnergyIconsRegex_7.Instance;

	/// <summary>
	/// Call this in your mod's initializer to enable simple localization processing for all strings in your mod.
	/// </summary>
	/// <param name="modId"></param>
	public static void EnableSimpleLoc(string modId)
	{
		SimpleLocEnabled.Add(modId);
	}

	[HarmonyPostfix]
	private static void ProcessSimpleLoc(string path, Dictionary<string, string>? __result)
	{
		if (__result == null)
		{
			return;
		}
		string[] array = StringExtensions.SimplifyPath(path).Split('/');
		int i;
		for (i = 0; i < array.Length && !(array[i] == "localization"); i++)
		{
		}
		if (i >= array.Length || i == 0)
		{
			return;
		}
		string item = array[i - 1];
		bool flag = SimpleLocEnabled.Contains(item);
		foreach (string item2 in __result.Keys.ToList())
		{
			string text = __result[item2];
			if (text.StartsWith('#'))
			{
				string text2 = text;
				__result[item2] = Simplify(text2.Substring(1, text2.Length - 1));
			}
			else if (flag)
			{
				__result[item2] = Simplify(text);
			}
		}
	}

	/// <summary>
	/// Simplify the given string if it starts with `#`.
	/// Does not check if mod as a whole has simplified text enabled.
	/// </summary>
	public static string TrySimplify(string loc)
	{
		if (loc.StartsWith('#'))
		{
			return Simplify(loc.Substring(1, loc.Length - 1));
		}
		return loc;
	}

	private static string Simplify(string loc)
	{
		if (loc.StartsWith('#'))
		{
			return loc;
		}
		loc = HighlightRegex.Replace(loc, "[gold]$1[/gold]$2");
		loc = NormalVariableRegex.Replace(loc, (Match match) => match.Groups[1].Value + SpecialVarDictionary.GetValueOrDefault(match.Groups[2].Value, match.Groups[2].Value) + match.Groups[3].Value);
		loc = DiffVariableRegex.Replace(loc, (Match match) => ReplaceVarName(match, ":diff()"));
		loc = InverseVariableRegex.Replace(loc, (Match match) => ReplaceVarName(match, ":inverseDiff()"));
		loc = EnergyIconsRegex.Replace(loc, MakeEnergyIcons);
		loc = PluralizeRegex.Replace(loc, "$1$2$3{$2:plural:|$4}");
		loc = UpgradeSwapRegex.Replace(loc, MakeUpgradeSwap);
		BaseLibMain.Logger.Info("SimplifiedLoc: " + loc, 1);
		return loc;
	}

	private static string MakeEnergyIcons(Match match)
	{
		if (match.Groups[1].Length > 0)
		{
			return "{Energy:energyIcons()}";
		}
		int length = match.Groups[2].Length;
		if (length != 0)
		{
			return $"{{energyPrefix:energyIcons({length})}}";
		}
		return match.Value;
	}

	private static string MakeUpgradeSwap(Match match)
	{
		string value = match.Groups[1].Value;
		string value2 = match.Groups[2].Value + match.Groups[3].Value;
		return $"{{IfUpgraded:show:{value2}|{value}}}";
	}

	private static string ReplaceVarName(Match match, string processor)
	{
		if (match.Groups.Count <= 1)
		{
			return match.Value;
		}
		string value = match.Groups[1].Value;
		return "{" + SpecialVarDictionary.GetValueOrDefault(value, value) + processor + "}";
	}
}
