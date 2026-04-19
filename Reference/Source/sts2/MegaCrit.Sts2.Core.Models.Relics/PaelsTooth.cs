using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsTooth : RelicModel
{
	public const int cardsCount = 5;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	public override extern bool HasUponPickupEffect { get; }

	[SavedProperty]
	public extern List<SerializableCard> SerializableCards { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__17))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CAfterCombatEnd_003Ed__18))]
	public override extern Task AfterCombatEnd(CombatRoom room);

	public extern void DebugAddCard(SerializableCard card);

	public extern PaelsTooth();
}
