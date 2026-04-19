using System.Collections.Generic;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Extensions;

public static class IEnumerableExtensions
{
	public static extern IEnumerable<T> TakeRandom<T>(this IEnumerable<T> collection, int count, Rng rng);
}
