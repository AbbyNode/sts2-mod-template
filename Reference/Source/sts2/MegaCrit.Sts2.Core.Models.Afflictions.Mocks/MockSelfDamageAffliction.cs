using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Afflictions.Mocks;

public sealed class MockSelfDamageAffliction : AfflictionModel
{
	public override extern bool IsStackable { get; }

	[AsyncStateMachine(typeof(_003COnPlay_003Ed__2))]
	public override extern Task OnPlay(PlayerChoiceContext choiceContext, Creature? target);

	public extern MockSelfDamageAffliction();
}
