using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Random;

public class Rng
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern Rng Chaotic
	{
		[CompilerGenerated]
		get;
	}

	public extern int Counter
	{
		[CompilerGenerated]
		get;
	}

	public extern uint Seed
	{
		[CompilerGenerated]
		get;
	}

	public extern Rng(uint seed = 0u, int counter = 0);

	public extern Rng(uint seed, string name);

	public extern void FastForwardCounter(int targetCount);

	public extern bool NextBool();

	public extern int NextInt(int maxExclusive = int.MaxValue);

	public extern int NextInt(int minInclusive, int maxExclusive);

	public extern uint NextUnsignedInt(uint maxExclusive = uint.MaxValue);

	public extern uint NextUnsignedInt(uint minInclusive, uint maxExclusive);

	public extern float NextFloat(float max = 1f);

	public extern float NextFloat(float min, float max);

	public extern double NextDouble();

	public extern double NextDouble(double min, double max);

	public extern float NextGaussianFloat(float mean = 0f, float stdDev = 1f, float min = 0f, float max = 1f);

	public extern double NextGaussianDouble(double mean = 0.0, double stdDev = 1.0, double min = 0.0, double max = 1.0);

	public extern int NextGaussianInt(int mean, int stdDev, int min, int max);

	public extern T? NextItem<T>(IEnumerable<T> items);

	public extern T? WeightedNextItem<T>(IEnumerable<T> items, Func<T?, float> weightFetcher);

	public static extern T WeightedNextItem<T>(float randInput, IEnumerable<T> items, Func<T, float> weightFetcher, T fallback);

	public extern void Shuffle<T>(IList<T> list);
}
