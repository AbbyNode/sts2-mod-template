namespace MegaCrit.Sts2.Core.Logging;

public class ConsoleLogPrinter : ILogPrinter
{
	public extern void Print(LogLevel logLevel, string text, int skipFrames);

	public extern ConsoleLogPrinter();
}
