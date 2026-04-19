using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class SoulFysh : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string HurtSfx { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern bool IsInvisible { get; set; }

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern SoulFysh();
}
