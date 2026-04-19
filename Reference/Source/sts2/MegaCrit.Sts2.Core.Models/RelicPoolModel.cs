using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models;

public abstract class RelicPoolModel : AbstractModel, IPoolModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract string EnergyColorName { get; }

	public virtual extern Color LabOutlineColor { get; }

	public extern IEnumerable<RelicModel> AllRelics { get; }

	public extern HashSet<ModelId> AllRelicIds { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	protected abstract IEnumerable<RelicModel> GenerateAllRelics();

	public virtual extern IEnumerable<RelicModel> GetUnlockedRelics(UnlockState unlockState);

	protected extern RelicPoolModel();
}
