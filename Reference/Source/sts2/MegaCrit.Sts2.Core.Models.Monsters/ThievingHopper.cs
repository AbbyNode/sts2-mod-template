using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class ThievingHopper : MonsterModel
{
	public const string stunTrigger = "StunTrigger";

	public const string hoverLoop = "event:/sfx/enemy/enemy_attacks/thieving_hopper/thieving_hopper_hover_loop";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern bool IsHovering { get; set; }

	public override extern string DeathSfx { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern string TakeDamageSfx { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__27))]
	public override extern Task AfterAddedToRoom();

	public override extern void BeforeRemovedFromRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern ThievingHopper();
}
