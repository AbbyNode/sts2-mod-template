using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SpiritOfAshPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CBeforeCardPlayed_003Ed__6))]
	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	public extern SpiritOfAshPower();
}
