using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models.Monsters;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class MindRot : CardModel, KnowledgeDemon.IChoosable
{
	public override extern bool CanBeGeneratedInCombat { get; }

	public override extern int MaxUpgradeLevel { get; }

	public extern MindRot();

	[AsyncStateMachine(typeof(_003COnChosen_003Ed__7))]
	public extern Task OnChosen();
}
