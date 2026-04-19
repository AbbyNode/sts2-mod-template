using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class MonarchsGazePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterDamageGiven_003Ed__4))]
	public override extern Task AfterDamageGiven(PlayerChoiceContext choiceContext, Creature? dealer, DamageResult _, ValueProp props, Creature target, CardModel? cardSource);

	public extern MonarchsGazePower();
}
