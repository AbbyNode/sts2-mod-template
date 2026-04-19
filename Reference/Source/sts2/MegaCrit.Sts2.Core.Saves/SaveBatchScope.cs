using System;

namespace MegaCrit.Sts2.Core.Saves;

public readonly struct SaveBatchScope : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern SaveBatchScope(SaveManager saveManager);

	public extern void Dispose();
}
