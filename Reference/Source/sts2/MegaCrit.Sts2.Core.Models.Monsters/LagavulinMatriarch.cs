using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class LagavulinMatriarch : MonsterModel
{
	public const string slashMoveId = "SLASH_MOVE";

	public const string wakeTrigger = "Wake";

	public const string awakenSfx = "event:/sfx/enemy/enemy_attacks/lagavulin_matriarch/lagavulin_matriarch_awaken";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern bool IsAwake { get; set; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__34))]
	public override extern Task AfterAddedToRoom();

	[AsyncStateMachine(typeof(_003CWakeUpMove_003Ed__40))]
	public extern Task WakeUpMove(IReadOnlyList<Creature> _);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern LagavulinMatriarch();
}
