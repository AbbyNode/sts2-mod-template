using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Vantom : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern bool ShouldDisappearFromDoom { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__28))]
	public override extern Task AfterAddedToRoom();

	public override extern void SetupSkins(NCreatureVisuals visuals);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern Vantom();
}
