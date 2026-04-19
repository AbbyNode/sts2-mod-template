using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BurningSticks : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterRoomEntered(AbstractRoom room);

	[AsyncStateMachine(typeof(_003CAfterCardExhausted_003Ed__9))]
	public override extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern BurningSticks();
}
