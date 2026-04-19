using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class OrbitPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int DisplayAmount { get; }

	public override extern bool IsInstanced { get; }

	[AsyncStateMachine(typeof(_003CAfterEnergySpent_003Ed__15))]
	public override extern Task AfterEnergySpent(CardModel card, int amount);

	public extern OrbitPower();
}
