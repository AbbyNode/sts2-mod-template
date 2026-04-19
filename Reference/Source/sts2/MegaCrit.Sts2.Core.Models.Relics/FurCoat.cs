using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class FurCoat : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[SavedProperty]
	public extern int FurCoatActIndex { get; set; }

	public override extern Task AfterObtained();

	public override extern ActMap ModifyGeneratedMapLate(IRunState runState, ActMap map, int actIndex);

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__24))]
	public override extern Task BeforeCombatStart();

	public extern List<MapCoord>? GetMarkedCoords();

	public extern FurCoat();
}
