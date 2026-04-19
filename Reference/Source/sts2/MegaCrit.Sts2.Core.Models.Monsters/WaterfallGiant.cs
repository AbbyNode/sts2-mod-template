using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class WaterfallGiant : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool HasDeathSfx { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__63))]
	public override extern Task AfterAddedToRoom();

	public override extern void BeforeRemovedFromRoom();

	[AsyncStateMachine(typeof(_003CTriggerAboutToBlowState_003Ed__76))]
	public extern Task TriggerAboutToBlowState();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern WaterfallGiant();
}
