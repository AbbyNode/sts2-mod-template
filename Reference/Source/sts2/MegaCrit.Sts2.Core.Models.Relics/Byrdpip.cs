using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Byrdpip : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool AddsPet { get; }

	public override extern RelicRarity Rarity { get; }

	public override extern bool HasUponPickupEffect { get; }

	public override extern bool SpawnsPets { get; }

	public static extern string[] SkinOptions { get; }

	[SavedProperty]
	public extern string Skin { get; set; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__16))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__17))]
	public override extern Task BeforeCombatStart();

	public extern Byrdpip();
}
