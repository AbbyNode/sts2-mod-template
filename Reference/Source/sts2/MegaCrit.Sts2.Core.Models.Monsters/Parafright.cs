using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Parafright : MonsterModel
{
	public const string healSfx = "event:/sfx/enemy/enemy_attacks/obscura/obscura_hologram_heal";

	public override extern string DeathSfx { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool HasDeathSfx { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__15))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern Parafright();
}
