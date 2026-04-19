using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class TheInsatiable : MonsterModel
{
	public const string eatPlayerTrigger = "EatPlayerTrigger";

	public const string finisherSfx = "event:/sfx/enemy/enemy_attacks/the_insatiable/the_insatiable_finisher";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string TheInsatiableTrackName { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__31))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern TheInsatiable();
}
