using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class TrashToTreasurePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterCardGeneratedForCombat_003Ed__4))]
	public override extern Task AfterCardGeneratedForCombat(CardModel card, bool addedByPlayer);

	public extern TrashToTreasurePower();
}
