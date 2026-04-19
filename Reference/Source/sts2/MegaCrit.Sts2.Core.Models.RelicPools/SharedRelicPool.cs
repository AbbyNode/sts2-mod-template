using System.Collections.Generic;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models.RelicPools;

public sealed class SharedRelicPool : RelicPoolModel
{
	public override extern string EnergyColorName { get; }

	public override extern IEnumerable<RelicModel> GetUnlockedRelics(UnlockState unlockState);

	public extern SharedRelicPool();
}
