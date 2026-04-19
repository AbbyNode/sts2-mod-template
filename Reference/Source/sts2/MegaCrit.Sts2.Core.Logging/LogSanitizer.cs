using System.Text.RegularExpressions;

namespace MegaCrit.Sts2.Core.Logging;

public static class LogSanitizer
{
	public static extern string Sanitize(string text);

	public static extern string ReplaceSteamId(Match m);
}
