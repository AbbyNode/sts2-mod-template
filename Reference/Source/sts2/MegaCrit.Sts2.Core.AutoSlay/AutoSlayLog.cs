using System;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.AutoSlay;

public static class AutoSlayLog
{
	public static extern void OpenLogFile(string path);

	public static extern void CloseLogFile();

	public static extern void Info(string message);

	public static extern void Warn(string message);

	public static extern void Error(string message);

	public static extern void Error(string message, Exception ex);

	public static extern void RunStarted(string seed);

	public static extern void RunCompleted(string seed);

	public static extern void RunFailed(string seed, Exception ex);

	public static extern void EnterRoom(RoomType type, int act, int floor);

	public static extern void ExitRoom(RoomType type);

	public static extern void EnterScreen(string screenName);

	public static extern void ExitScreen(string screenName);

	public static extern void Action(string action);

	public static extern void StateSnapshot(RunState? runState);
}
