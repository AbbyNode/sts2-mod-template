using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsEye : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public override extern bool ShouldTakeExtraTurn(Player player);

	[AsyncStateMachine(typeof(_003CBeforeTurnEndEarly_003Ed__15))]
	public override extern Task BeforeTurnEndEarly(PlayerChoiceContext choiceContext, CombatSide side);

	public override extern Task AfterTakingExtraTurn(Player player);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern PaelsEye();
}
