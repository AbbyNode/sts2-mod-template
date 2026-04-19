using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class BlockingPlayerChoiceContext : PlayerChoiceContext
{
	public override extern Task SignalPlayerChoiceBegun(PlayerChoiceOptions options);

	public override extern Task SignalPlayerChoiceEnded();

	public extern BlockingPlayerChoiceContext();
}
