using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Logging;

public class Logger
{
	public static readonly Dictionary<LogType, LogLevel> logLevelTypeMap;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern LogLevel GlobalLogLevel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string? Context
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern event Action<LogLevel, string, int>? LogCallback;

	public extern Logger(string? context, LogType logType);

	public extern bool WillLog(LogLevel level);

	public extern void LogMessage(LogLevel level, string text, int skipFrames);

	public extern void LogMessage(LogLevel level, LogType type, string text, int skipFrames);

	public extern void Load(string text, int skipFrames = 1);

	public extern void Debug(string text, int skipFrames = 1);

	public extern void VeryDebug(string text, int skipFrames = 1);

	public extern void Info(string text, int skipFrames = 1);

	public extern void Warn(string text, int skipFrames = 1);

	public extern void Error(string text, int skipFrames = 1);

	public static extern void SetLogLevelForType(LogType type, LogLevel? logLevel);
}
