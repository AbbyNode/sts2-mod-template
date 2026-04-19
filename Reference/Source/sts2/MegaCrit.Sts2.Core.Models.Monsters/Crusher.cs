using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Crusher : MonsterModel
{
	public const string deathVfxPath = "vfx/monsters/kaiser_crab_boss_explosion";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IEnumerable<string> AssetPaths { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	public override extern float DeathAnimLengthOverride { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__27))]
	public override extern Task AfterAddedToRoom();

	public override extern Task AfterCurrentHpChanged(Creature creature, decimal delta);

	public override extern Task BeforeDeath(Creature creature);

	public extern Crusher();
}
