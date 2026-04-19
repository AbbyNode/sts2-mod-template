using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Mawler : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern Mawler();
}
