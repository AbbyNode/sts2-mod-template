using System;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions;

public class ReadyToBeginEnemyTurnAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern ReadyToBeginEnemyTurnAction(Player player, Func<Task>? actionDuringEnemyTurn = null);

	protected override extern Task ExecuteAction();

	public override extern INetAction ToNetAction();

	protected override extern void CancelAction();

	public override extern string ToString();
}
