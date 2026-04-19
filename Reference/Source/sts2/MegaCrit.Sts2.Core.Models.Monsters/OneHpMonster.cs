using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class OneHpMonster : MonsterModel
{
	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern OneHpMonster();
}
