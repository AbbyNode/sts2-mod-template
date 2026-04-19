using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class SneckoEye : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__7))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__8))]
	public override extern Task BeforeCombatStart();

	public override extern decimal ModifyHandDraw(Player player, decimal count);

	public extern void SetTestEnergyCostOverride(int value);

	public extern SneckoEye();
}
