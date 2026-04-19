using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class HailstormPower : PowerModel
{
	public const string frostOrbKey = "FrostOrbs";

	public const int frostOrbCount = 1;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__10))]
	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern HailstormPower();
}
