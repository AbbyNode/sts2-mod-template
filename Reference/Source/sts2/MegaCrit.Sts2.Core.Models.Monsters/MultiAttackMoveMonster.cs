using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class MultiAttackMoveMonster : MonsterModel
{
	public const int repeat = 5;

	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern MultiAttackMoveMonster();
}
