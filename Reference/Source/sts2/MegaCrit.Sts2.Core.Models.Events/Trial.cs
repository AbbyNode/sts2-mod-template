using System.Collections.Generic;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class Trial : EventModel
{
	public override extern IEnumerable<string> GetAssetPaths(IRunState runState);

	public override extern void CalculateVars();

	public extern Trial();
}
