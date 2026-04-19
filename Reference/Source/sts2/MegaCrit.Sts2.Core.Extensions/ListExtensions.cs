using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Extensions;

public static class ListExtensions
{
	public static extern List<T> StableShuffle<T>(this List<T> list, Rng rng) where T : IComparable<T>;

	public static extern List<T> UnstableShuffle<T>(this List<T> list, Rng rng);

	public static extern int IndexOf<T>(this IReadOnlyList<T> readOnlyList, T item);

	public static extern int FirstIndex<T>(this IReadOnlyList<T> readOnlyList, Predicate<T> match);
}
