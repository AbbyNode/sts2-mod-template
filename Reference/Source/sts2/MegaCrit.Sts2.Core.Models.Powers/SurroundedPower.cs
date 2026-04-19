using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SurroundedPower : PowerModel
{
	public enum Direction
	{
		Right,
		Left
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public extern Direction Facing { get; }

	public override extern decimal ModifyDamageMultiplicative(Creature? target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CBeforeCardPlayed_003Ed__10))]
	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CBeforePotionUsed_003Ed__11))]
	public override extern Task BeforePotionUsed(PotionModel potion, Creature? target);

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__12))]
	public override extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	public extern SurroundedPower();
}
