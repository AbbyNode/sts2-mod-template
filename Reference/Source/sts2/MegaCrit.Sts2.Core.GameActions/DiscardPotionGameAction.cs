using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions;

public class DiscardPotionGameAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern bool WasEnqueuedInCombat
	{
		[CompilerGenerated]
		get;
	}

	public extern DiscardPotionGameAction(Player player, uint potionSlotIndex, bool isCombatInProgress);

	[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__10))]
	protected override extern Task ExecuteAction();

	public override extern INetAction ToNetAction();

	public override extern string ToString();
}
