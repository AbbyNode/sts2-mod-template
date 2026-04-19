using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class TeaOfDiscourtesy : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsUsedUp { get; }

	public override extern bool ShowCounter { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__16))]
	public override extern Task BeforeCombatStart();

	public extern TeaOfDiscourtesy();
}
