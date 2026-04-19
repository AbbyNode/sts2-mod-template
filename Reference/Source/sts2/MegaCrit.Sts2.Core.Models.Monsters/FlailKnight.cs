using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public class FlailKnight : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	protected override extern MonsterMoveStateMachine GenerateMoveStateMachine();

	[AsyncStateMachine(typeof(_003CFlailMove_003Ed__19))]
	public extern Task FlailMove(IReadOnlyList<Creature> targets);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern FlailKnight();
}
