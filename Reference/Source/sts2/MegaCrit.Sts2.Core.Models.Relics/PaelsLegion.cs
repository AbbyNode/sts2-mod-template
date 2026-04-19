using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsLegion : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool AddsPet { get; }

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public static extern string[] SkinOptions { get; }

	[SavedProperty]
	public extern string Skin { get; set; }

	public override extern int DisplayAmount { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__31))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__32))]
	public override extern Task BeforeCombatStart();

	public override extern decimal ModifyBlockMultiplicative(Creature target, decimal block, ValueProp props, CardModel? cardSource, CardPlay? cardPlay);

	public override extern Task AfterModifyingBlockAmount(decimal modifiedAmount, CardModel? cardSource, CardPlay? cardPlay);

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__35))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__36))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern PaelsLegion();
}
