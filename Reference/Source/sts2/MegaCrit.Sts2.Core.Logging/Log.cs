using System;

namespace MegaCrit.Sts2.Core.Logging;

public static class Log
{
	public static extern string Timestamp { get; }

	public static extern event Action<LogLevel, string, int>? LogCallback;

	public static extern void InvokeGlobalLogCallback(LogLevel logLevel, string log, int skipFrames);

	public static extern void Load(string text, int skipFrames = 2);

	public static extern void Debug(string text, int skipFrames = 2);

	public static extern void VeryDebug(string text, int skipFrames = 2);

	public static extern void Info(string text, int skipFrames = 2);

	public static extern void Warn(string text, int skipFrames = 2);

	public static extern void Error(string text, int skipFrames = 2);

	public static extern void LogMessage(LogLevel level, LogType type, string text, int skipFrames = 1);
}
