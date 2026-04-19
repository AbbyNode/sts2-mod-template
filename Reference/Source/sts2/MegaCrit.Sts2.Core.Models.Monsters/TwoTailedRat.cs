using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class TwoTailedRat : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string DeathSfx { get; }

	public override extern string HurtSfx { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern int StarterMoveIndex { get; set; }

	public extern int CallForBackupCount { get; set; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__36))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern TwoTailedRat();
}
