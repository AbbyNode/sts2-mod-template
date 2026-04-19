using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Door : MonsterModel
{
	public const string initialMoveId = "DRAMATIC_OPEN_MOVE";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern MoveState DeadState { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	public extern Creature Doormaker { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__28))]
	public override extern Task AfterAddedToRoom();

	public extern void PrepareForRevival();

	public extern void PrepareForDeath();

	public extern void Close();

	public extern void Open();

	public extern Door();
}
