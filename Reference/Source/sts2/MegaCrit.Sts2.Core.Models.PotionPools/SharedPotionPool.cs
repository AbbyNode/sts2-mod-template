using System.Collections.Generic;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models.PotionPools;

public sealed class SharedPotionPool : PotionPoolModel
{
	public override extern string EnergyColorName { get; }

	public override extern IEnumerable<PotionModel> GetUnlockedPotions(UnlockState unlockState);

	public extern SharedPotionPool();
}
