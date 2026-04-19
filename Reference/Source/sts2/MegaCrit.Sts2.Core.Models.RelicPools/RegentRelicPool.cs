using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models.RelicPools;

public sealed class RegentRelicPool : RelicPoolModel
{
	public override extern string EnergyColorName { get; }

	public override extern Color LabOutlineColor { get; }

	public override extern IEnumerable<RelicModel> GetUnlockedRelics(UnlockState unlockState);

	public extern RegentRelicPool();
}
