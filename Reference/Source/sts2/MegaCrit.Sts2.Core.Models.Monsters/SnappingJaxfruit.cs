using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class SnappingJaxfruit : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__15))]
	public override extern Task AfterAddedToRoom();

	public override extern void BeforeRemovedFromRoom();

	[AsyncStateMachine(typeof(_003CEnergyOrb_003Ed__18))]
	public extern Task EnergyOrb(IReadOnlyList<Creature> targets);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern SnappingJaxfruit();
}
