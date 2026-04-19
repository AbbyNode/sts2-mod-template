using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class FanOfKnives : CardModel
{
	public extern FanOfKnives();

	[AsyncStateMachine(typeof(_003COnEnqueuePlayVfx_003Ed__9))]
	public override extern Task OnEnqueuePlayVfx(Creature? target);
}
