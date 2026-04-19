using System;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public static class ActionTypes
{
	public static extern int TypeToId<T>() where T : INetAction;

	public static extern int ToId(this INetAction message);

	public static extern bool TryGetActionType(int id, out Type? type);
}
