namespace MegaCrit.Sts2.Core.Logging;

public class EditorLogPrinter : ILogPrinter
{
	public extern void Print(LogLevel level, string text, int skipFrames);

	public extern EditorLogPrinter();
}
