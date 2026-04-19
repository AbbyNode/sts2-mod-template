using System.Collections.Generic;

namespace BaseLib.Utils;

public static class ChainedEnumerableExtension
{
	public static ChainedEnumerable<T> Chain<T>(this IEnumerable<T> enumerable, params IEnumerable<T> additional)
	{
		return new ChainedEnumerable<T>(enumerable, additional);
	}
}
