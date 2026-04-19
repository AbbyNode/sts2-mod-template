using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class PaelsLegion : MonsterModel
{
	public const string blockTrigger = "BlockTrigger";

	public const string sleepTrigger = "SleepTrigger";

	public const string wakeUpTrigger = "WakeUpTrigger";

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool IsHealthBarVisible { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern PaelsLegion();
}
