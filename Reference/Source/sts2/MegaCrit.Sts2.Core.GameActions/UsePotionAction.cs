using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.GameActions;

public class UsePotionAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern uint PotionIndex
	{
		[CompilerGenerated]
		get;
	}

	public extern uint? TargetId
	{
		[CompilerGenerated]
		get;
	}

	public extern bool WasEnqueuedInCombat
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerChoiceContext? PlayerChoiceContext
	{
		[CompilerGenerated]
		get;
	}

	public extern UsePotionAction(PotionModel potion, Creature? target, bool isCombatInProgress);

	public extern UsePotionAction(Player player, uint potionIndex, uint? targetId, ulong? targetPlayerId, bool isCombatInProgress);

	[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__25))]
	protected override extern Task ExecuteAction();

	protected override extern void CancelAction();

	public override extern INetAction ToNetAction();

	public override extern string ToString();
}
