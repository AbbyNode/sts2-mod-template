using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.DevConsole;

public class ConsoleCmdGameAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern string Cmd
	{
		[CompilerGenerated]
		get;
	}

	public extern ConsoleCmdGameAction(Player player, string cmd);

	[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__13))]
	protected override extern Task ExecuteAction();

	public override extern INetAction ToNetAction();
}
