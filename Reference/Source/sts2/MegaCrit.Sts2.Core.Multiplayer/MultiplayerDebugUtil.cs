using System;

namespace MegaCrit.Sts2.Core.Multiplayer;

public static class MultiplayerDebugUtil
{
	public static extern string FormatAsHex(ReadOnlySpan<byte> data, int lineWidth = 16, int byteWidth = 1);

	public static extern byte[] StringToByteArray(string hex);
}
