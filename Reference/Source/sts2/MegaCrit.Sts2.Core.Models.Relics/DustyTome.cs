using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class DustyTome : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[SavedProperty]
	public extern ModelId? AncientCard { get; set; }

	public extern void SetupForPlayer(Player player);

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__13))]
	public override extern Task AfterObtained();

	public extern DustyTome();
}
