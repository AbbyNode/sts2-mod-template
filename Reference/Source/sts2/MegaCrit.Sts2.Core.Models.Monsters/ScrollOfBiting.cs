using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class ScrollOfBiting : MonsterModel
{
	public const string biteSfx = "event:/sfx/enemy/enemy_attacks/scroll_of_biting/scroll_of_biting_bite";

	public const string biteDoubleSfx = "event:/sfx/enemy/enemy_attacks/scroll_of_biting/scroll_of_biting_bite_double";

	public const string buffSfx = "event:/sfx/enemy/enemy_attacks/scroll_of_biting/scroll_of_biting_buff";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool HasDeathSfx { get; }

	public override extern string DeathSfx { get; }

	public extern int StarterMoveIdx { get; set; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__26))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern ScrollOfBiting();
}
