using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Inflame : CardModel
{
	public extern Inflame();

	[AsyncStateMachine(typeof(_003COnEnqueuePlayVfx_003Ed__8))]
	public override extern Task OnEnqueuePlayVfx(Creature? target);
}
