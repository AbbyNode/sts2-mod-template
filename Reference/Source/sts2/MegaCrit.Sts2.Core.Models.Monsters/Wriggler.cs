using MegaCrit.Sts2.Core.Audio;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Wriggler : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern bool StartStunned { get; set; }

	public extern Wriggler();
}
