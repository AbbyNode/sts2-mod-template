using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class SlumberingBeetle : MonsterModel
{
	public const string wakeUpTrigger = "WakeUp";

	public const string rolloutMoveId = "ROLL_OUT_MOVE";

	public const string wakeUp = "event:/sfx/enemy/enemy_attacks/slumbering_beetle/slumbering_beetle_wake_up";

	public const string sleepLoop = "event:/sfx/enemy/enemy_attacks/slumbering_beetle/slumbering_beetle_sleep_loop";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern bool IsAwake { get; set; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__22))]
	public override extern Task AfterAddedToRoom();

	[AsyncStateMachine(typeof(_003CWakeUpMove_003Ed__24))]
	public extern Task WakeUpMove(IReadOnlyList<Creature> _);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern SlumberingBeetle();
}
