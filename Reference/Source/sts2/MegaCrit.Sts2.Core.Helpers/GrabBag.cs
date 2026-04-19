using System;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Helpers;

public class GrabBag<T>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Count { get; }

	public extern void Add(T element, double weight);

	public extern T? Grab(Rng rng, Func<T, bool>? predicate = null);

	public extern T? GrabAndRemove(Rng rng, Func<T, bool>? predicate = null);

	public extern bool Any();

	public extern GrabBag();
}
