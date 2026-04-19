using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class MonsterModel : AbstractModel
{
	public static readonly Vector2 defaultDeathVfxPadding;

	public const string stunnedMoveId = "STUNNED";

	protected const string _locTableName = "monsters";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern LocString Title { get; }

	public abstract int MinInitialHp { get; }

	public abstract int MaxInitialHp { get; }

	public virtual extern bool IsHealthBarVisible { get; }

	public virtual extern Vector2 ExtraDeathVfxPadding { get; }

	public virtual extern float HpBarSizeReduction { get; }

	protected virtual extern string VisualsPath { get; }

	public virtual extern IEnumerable<string> AssetPaths { get; }

	public extern Rng Rng { get; set; }

	public extern RunRngSet RunRng { get; set; }

	public extern bool IsPerformingMove { get; }

	public extern IEnumerable<LocString> MoveNames { get; }

	public virtual extern string BestiaryAttackAnimId { get; }

	protected virtual extern string AttackSfx { get; }

	protected virtual extern string CastSfx { get; }

	public virtual extern string DeathSfx { get; }

	public virtual extern bool HasDeathSfx { get; }

	public virtual extern string? HurtSfx { get; }

	public virtual extern bool HasHurtSfx { get; }

	public virtual extern bool ShouldFadeAfterDeath { get; }

	public virtual extern bool ShouldDisappearFromDoom { get; }

	public virtual extern float DeathAnimLengthOverride { get; }

	public extern bool HasDeathAnimLengthOverride { get; }

	public virtual extern bool CanChangeScale { get; }

	public virtual extern DamageSfxType TakeDamageSfxType { get; }

	public virtual extern string TakeDamageSfx { get; }

	public extern Creature Creature { get; set; }

	public extern CombatState CombatState { get; }

	public extern MonsterMoveStateMachine? MoveStateMachine { get; }

	public extern MoveState NextMove
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IntendsToAttack { get; }

	public extern bool SpawnedThisTurn { get; }

	public extern MonsterModel CanonicalInstance { get; }

	public extern NCreatureVisuals CreateVisuals();

	public virtual extern Task AfterAddedToRoom();

	public virtual extern void BeforeRemovedFromRoom();

	public virtual extern List<BestiaryMonsterMove> MonsterMoveList(NCreatureVisuals creatureVisuals);

	public extern void ResetStateMachine();

	public static extern LocString L10NMonsterLookup(string entryName);

	public extern MonsterModel ToMutable();

	protected abstract MonsterMoveStateMachine GenerateMoveStateMachine();

	public extern void SetUpForCombat();

	public extern void RollMove(IEnumerable<Creature> targets);

	public extern void SetMoveImmediate(MoveState state, bool forceTransition = false);

	[AsyncStateMachine(typeof(_003CPerformMove_003Ed__99))]
	public extern Task PerformMove();

	public virtual extern void SetupSkins(NCreatureVisuals visuals);

	public virtual extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern void OnSideSwitch();

	public virtual extern void OnDieToDoom();

	protected extern LocString GetBestiaryMoveName(string moveId);

	protected extern MonsterModel();
}
