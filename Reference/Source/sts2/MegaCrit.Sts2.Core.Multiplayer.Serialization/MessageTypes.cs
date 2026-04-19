using System;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public static class MessageTypes
{
	public static extern int TypeToId<T>() where T : INetMessage;

	public static extern int ToId(this INetMessage message);

	public static extern bool TryGetMessageType(int id, out Type? type);
}
