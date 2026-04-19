using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

namespace MegaCrit.Sts2.Core.Models.Monsters.Mocks;

public sealed class MockReattachMonster : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern MoveState DeadState { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__10))]
	public override extern Task AfterAddedToRoom();

	public extern MockReattachMonster();
}
