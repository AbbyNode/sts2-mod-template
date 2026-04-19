using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class FakeOrichalcum : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern int MerchantCost { get; }

	public override extern Task BeforeTurnEndVeryEarly(PlayerChoiceContext choiceContext, CombatSide side);

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__13))]
	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public extern FakeOrichalcum();
}
