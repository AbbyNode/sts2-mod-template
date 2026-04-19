using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class CalcifiedCultist : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern Vector2 ExtraDeathVfxPadding { get; }

	public override extern string DeathSfx { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern CalcifiedCultist();
}
