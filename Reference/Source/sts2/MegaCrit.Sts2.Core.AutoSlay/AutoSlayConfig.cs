using System;

namespace MegaCrit.Sts2.Core.AutoSlay;

public static class AutoSlayConfig
{
	public static readonly TimeSpan runTimeout;

	public static readonly TimeSpan defaultRoomTimeout;

	public static readonly TimeSpan defaultScreenTimeout;

	public static readonly TimeSpan gameInitTimeout;

	public static readonly TimeSpan runStateTimeout;

	public static readonly TimeSpan nodeWaitTimeout;

	public static readonly TimeSpan mapScreenTimeout;

	public static readonly TimeSpan pollingInterval;

	public static readonly TimeSpan buttonClickDelay;

	public const int maxFloor = 49;

	public static readonly TimeSpan watchdogTimeout;

	public static readonly TimeSpan watchdogLogInterval;
}
