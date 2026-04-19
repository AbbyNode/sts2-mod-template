using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class HookPlayerChoiceContext : PlayerChoiceContext
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern AbstractModel? Source
	{
		[CompilerGenerated]
		get;
	}

	public extern Task? Task
	{
		[CompilerGenerated]
		get;
	}

	public extern Player? Owner
	{
		[CompilerGenerated]
		get;
	}

	public extern GenericHookGameAction? GameAction { get; }

	public extern HookPlayerChoiceContext(Player owner, ulong localPlayerId, GameActionType gameActionType);

	public extern HookPlayerChoiceContext(AbstractModel source, ulong localPlayerId, CombatState combatState, GameActionType gameActionType);

	public extern void MockDependenciesForTest(ActionQueueSynchronizer? actionQueueSynchronizer, ActionQueueSet? actionQueueSet, ActionExecutor? actionExecutor);

	[AsyncStateMachine(typeof(_003CAssignTaskAndWaitForPauseOrCompletion_003Ed__29))]
	public extern Task<bool> AssignTaskAndWaitForPauseOrCompletion(Task task);

	[AsyncStateMachine(typeof(_003CSignalPlayerChoiceBegun_003Ed__31))]
	public override extern Task SignalPlayerChoiceBegun(PlayerChoiceOptions options);

	[AsyncStateMachine(typeof(_003CSignalPlayerChoiceEnded_003Ed__32))]
	public override extern Task SignalPlayerChoiceEnded();
}
