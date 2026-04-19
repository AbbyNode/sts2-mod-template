using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Singleton;

public class MultiplayerScalingModel : SingletonModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern void Initialize(RunState state);

	public extern void OnCombatEntered(CombatState combatState);

	public extern void OnCombatFinished();

	public override extern decimal ModifyBlockMultiplicative(Creature target, decimal block, ValueProp props, CardModel? cardSource, CardPlay? cardPlay);

	public override extern decimal ModifyPowerAmountGiven(PowerModel power, Creature giver, decimal amount, Creature? target, CardModel? cardSource);

	public static extern decimal GetMultiplayerScaling(EncounterModel? encounter, int actIndex);

	public extern MultiplayerScalingModel();
}
