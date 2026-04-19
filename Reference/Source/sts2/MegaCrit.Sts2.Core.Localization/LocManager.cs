using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Localization;

public class LocManager
{
	public delegate void LocaleChangeCallback();

	public const string locOverrideDir = "user://localization_override";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern LocManager Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern bool OverridesActive
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<LocValidationError> ValidationErrors
	{
		[CompilerGenerated]
		get;
	}

	public extern string Language
	{
		[CompilerGenerated]
		get;
	}

	public static extern List<string> Languages
	{
		[CompilerGenerated]
		get;
	}

	public extern CultureInfo CultureInfo
	{
		[CompilerGenerated]
		get;
	}

	public static extern void Initialize();

	public extern LocManager();

	public extern float GetLanguageCompletion(string language);

	public extern string SmartFormat(LocString locString, Dictionary<string, object> variables);

	[MemberNotNull(new string[] { "CultureInfo", "Language" })]
	public extern void SetLanguage(string language);

	public extern void StartOverridingLanguageAsEnglish();

	public extern void StopOverridingLanguageAsEnglish();

	public extern LocTable GetTable(string name);

	public extern void SubscribeToLocaleChange(LocaleChangeCallback callback);

	public extern void UnsubscribeToLocaleChange(LocaleChangeCallback callback);
}
