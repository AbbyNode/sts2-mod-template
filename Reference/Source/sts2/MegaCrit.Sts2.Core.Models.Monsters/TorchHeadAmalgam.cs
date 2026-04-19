using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class TorchHeadAmalgam : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__14))]
	public override extern Task AfterAddedToRoom();

	public override extern void OnDieToDoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern TorchHeadAmalgam();
}
