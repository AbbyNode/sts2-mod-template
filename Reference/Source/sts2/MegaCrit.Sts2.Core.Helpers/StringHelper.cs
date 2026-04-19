using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Helpers;

public static class StringHelper
{
	public static extern string SnakeCase(string txt);

	public static extern string Slugify(string txt);

	public static extern string Unslugify(string txt);

	public static extern string CompactText(string text);

	public static extern int GetDeterministicHashCode(string str);

	public static extern string Radix(int value);

	public static extern LocString RatioFormat(int numerator, int denominator);

	public static extern LocString RatioFormat(string numerator, string denominator);

	public static extern string Capitalize(string input);

	public static extern string StripBbCode(this string text);
}
