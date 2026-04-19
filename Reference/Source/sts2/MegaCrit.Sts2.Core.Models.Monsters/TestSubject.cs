using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class TestSubject : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern int FirstFormHp { get; }

	public extern int SecondFormHp { get; }

	public extern int ThirdFormHp { get; }

	public override extern string DeathSfx { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	[AsyncStateMachine(typeof(_003CTriggerDeadState_003Ed__65))]
	public extern Task TriggerDeadState();

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__66))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern TestSubject();
}
