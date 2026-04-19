using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class TouchOfOrobas : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[SavedProperty]
	public extern ModelId? StarterRelic { get; set; }

	[SavedProperty]
	public extern ModelId? UpgradedRelic { get; set; }

	public extern RelicModel GetUpgradedStarterRelic(RelicModel starterRelic);

	public extern bool SetupForPlayer(Player player);

	public extern void SetupForTests(ModelId starterRelic, ModelId upgradedRelic);

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__24))]
	public override extern Task AfterObtained();

	public extern TouchOfOrobas();
}
