using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models.Monsters;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Sloth : CardModel, KnowledgeDemon.IChoosable
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern bool CanBeGeneratedInCombat { get; }

	public extern Sloth();

	[AsyncStateMachine(typeof(_003COnChosen_003Ed__7))]
	public extern Task OnChosen();
}
