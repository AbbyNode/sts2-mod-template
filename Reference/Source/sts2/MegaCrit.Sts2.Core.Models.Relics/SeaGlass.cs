using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public class SeaGlass : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	[SavedProperty]
	public extern ModelId? CharacterId { get; set; }

	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	protected override extern IEnumerable<DynamicVar> CanonicalVars { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__15))]
	public override extern Task AfterObtained();

	public extern SeaGlass();
}
