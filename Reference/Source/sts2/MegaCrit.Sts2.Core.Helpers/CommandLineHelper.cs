namespace MegaCrit.Sts2.Core.Helpers;

public static class CommandLineHelper
{
	public static extern bool HasArg(string key);

	public static extern bool TryGetValue(string key, out string? value);

	public static extern string? GetValue(string key);
}
