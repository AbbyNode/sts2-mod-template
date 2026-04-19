using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public abstract class PlayerChoiceContext
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern AbstractModel? LastInvolvedModel { get; }

	public extern void PushModel(AbstractModel model);

	public extern void PopModel(AbstractModel model);

	public abstract Task SignalPlayerChoiceBegun(PlayerChoiceOptions options);

	public abstract Task SignalPlayerChoiceEnded();

	protected extern PlayerChoiceContext();
}
