using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models.PotionPools;

public sealed class DefectPotionPool : PotionPoolModel
{
	public override extern string EnergyColorName { get; }

	public override extern Color LabOutlineColor { get; }

	public override extern IEnumerable<PotionModel> GetUnlockedPotions(UnlockState unlockState);

	public extern DefectPotionPool();
}
