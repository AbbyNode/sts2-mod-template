using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.DevConsole;

public class FixedSizedQueue<T> : List<T>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern FixedSizedQueue(int limit);

	public extern void Enqueue(T obj);
}
