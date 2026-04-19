using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class LouseProgenitor : MonsterModel
{
	public const string curlTrigger = "Curl";

	public const string curlSfx = "event:/sfx/enemy/enemy_attacks/giant_louse/giant_louse_curl";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern string DeathSfx { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern bool Curled { get; set; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__28))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern LouseProgenitor();
}
