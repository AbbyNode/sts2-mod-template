using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Inklet : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern bool MiddleInklet { get; set; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern string HurtSfx { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__21))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern Inklet();
}
