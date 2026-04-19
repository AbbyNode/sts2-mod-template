using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public abstract class DecimillipedeSegment : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public extern int StarterMoveIdx { get; set; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern float HpBarSizeReduction { get; }

	public extern MoveState DeadState { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	public override extern bool CanChangeScale { get; }

	public override extern string DeathSfx { get; }

	public override extern IEnumerable<string> AssetPaths { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__41))]
	public override extern Task AfterAddedToRoom();

	protected override extern MonsterMoveStateMachine GenerateMoveStateMachine();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	protected abstract void SegmentAttack();

	protected extern DecimillipedeSegment();
}
