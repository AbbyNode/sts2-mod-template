using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class GameActionPlayerChoiceContext : PlayerChoiceContext
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern GameAction Action
	{
		[CompilerGenerated]
		get;
	}

	public extern GameActionPlayerChoiceContext(GameAction action);

	public override extern Task SignalPlayerChoiceBegun(PlayerChoiceOptions options);

	[AsyncStateMachine(typeof(_003CSignalPlayerChoiceEnded_003Ed__5))]
	public override extern Task SignalPlayerChoiceEnded();
}
