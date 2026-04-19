using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters.Mocks;

public sealed class MockIntangibleMonster : MonsterModel
{
	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern MockIntangibleMonster();
}
