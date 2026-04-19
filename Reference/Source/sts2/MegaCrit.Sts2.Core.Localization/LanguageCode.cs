using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Localization;

public class LanguageCode
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string Code
	{
		[CompilerGenerated]
		get;
	}

	public extern LanguageCode(string code);

	public extern bool IsValid();

	public override extern string ToString();
}
