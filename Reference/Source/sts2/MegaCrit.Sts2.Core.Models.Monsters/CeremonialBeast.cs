using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class CeremonialBeast : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	public override extern string DeathSfx { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern MoveState BeastCryState { get; set; }

	[AsyncStateMachine(typeof(_003CSetStunned_003Ed__50))]
	public extern Task SetStunned();

	[AsyncStateMachine(typeof(_003CStunnedMove_003Ed__51))]
	public extern Task StunnedMove(IReadOnlyList<Creature> targets);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public override extern List<BestiaryMonsterMove> MonsterMoveList(NCreatureVisuals creatureVisuals);

	public extern CeremonialBeast();
}
