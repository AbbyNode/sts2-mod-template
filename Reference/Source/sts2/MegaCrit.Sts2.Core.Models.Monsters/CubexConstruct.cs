using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class CubexConstruct : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern string BestiaryAttackAnimId { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__22))]
	public override extern Task AfterAddedToRoom();

	public override extern void BeforeRemovedFromRoom();

	public extern void OnHpChanged(int oldHp, int newHp);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern CubexConstruct();
}
