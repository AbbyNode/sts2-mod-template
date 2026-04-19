using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;

namespace MegaCrit.Sts2.Core.GameActions;

public class PickRelicAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern TreasureRoomRelicSynchronizer? TestSynchronizer
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern PickRelicAction(Player player, int relicIndex);

	protected override extern Task ExecuteAction();

	public override extern INetAction ToNetAction();

	public override extern string ToString();
}
