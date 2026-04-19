using System;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public static class MaxEnumValueCache
{
	public static extern int Get<T>() where T : struct, Enum;
}
