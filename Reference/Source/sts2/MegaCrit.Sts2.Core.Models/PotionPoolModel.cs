using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models;

public abstract class PotionPoolModel : AbstractModel, IPoolModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract string EnergyColorName { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern Color LabOutlineColor { get; }

	public extern IEnumerable<PotionModel> AllPotions { get; }

	public extern IEnumerable<ModelId> AllPotionIds { get; }

	protected abstract IEnumerable<PotionModel> GenerateAllPotions();

	public virtual extern IEnumerable<PotionModel> GetUnlockedPotions(UnlockState unlockState);

	protected extern PotionPoolModel();
}
