using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Fabricator : MonsterModel
{
	public static readonly HashSet<MonsterModel> aggroSpawns;

	public static readonly HashSet<MonsterModel> defenseSpawns;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string HurtSfx { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	public extern Fabricator();
}
