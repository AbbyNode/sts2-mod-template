using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class JossPaper : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string FlashSfx { get; }

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty(SerializationCondition.SaveIfNotTypeDefault)]
	public extern int CardsExhausted { get; set; }

	[AsyncStateMachine(typeof(_003CAfterCardExhausted_003Ed__25))]
	public override extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__26))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern JossPaper();
}
