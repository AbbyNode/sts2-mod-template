using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class SlimedBerserker : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool HasDeathSfx { get; }

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern SlimedBerserker();
}
