using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions;

public class GenericHookGameAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool RecordableToReplay { get; }

	public extern HookPlayerChoiceContext? ChoiceContext
	{
		[CompilerGenerated]
		get;
	}

	public override extern ulong OwnerId
	{
		[CompilerGenerated]
		get;
	}

	public override extern GameActionType ActionType { get; }

	public extern uint HookId
	{
		[CompilerGenerated]
		get;
	}

	public extern Task ExecutionStartedTask { get; }

	public extern GenericHookGameAction(uint hookId, ulong ownerId, GameActionType gameActionType);

	public extern void SetChoiceContext(HookPlayerChoiceContext choiceContext);

	[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__21))]
	protected override extern Task ExecuteAction();

	public override extern INetAction ToNetAction();

	public override extern string ToString();
}
