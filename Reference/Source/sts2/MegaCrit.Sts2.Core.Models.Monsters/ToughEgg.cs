using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class ToughEgg : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern int HatchlingMinHp { get; }

	public extern int HatchlingMaxHp { get; }

	public override extern string DeathSfx { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern MonsterState? AfterHatchedState { get; set; }

	public extern bool IsHatched { get; set; }

	public extern Vector2? HatchPos { get; set; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__33))]
	public override extern Task AfterAddedToRoom();

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern ToughEgg();
}
