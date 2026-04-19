using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Commands.Builders;

public class AttackCommand
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Creature? Attacker
	{
		[CompilerGenerated]
		get;
	}

	public extern AbstractModel? ModelSource
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatSide TargetSide
	{
		[CompilerGenerated]
		get;
	}

	public extern ValueProp DamageProps
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsSingleTargeted { get; }

	public extern bool IsMultiTargeted { get; }

	public extern bool IsRandomlyTargeted
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<DamageResult> Results { get; }

	public extern string? HitSfx
	{
		[CompilerGenerated]
		get;
	}

	public extern string? TmpHitSfx
	{
		[CompilerGenerated]
		get;
	}

	public extern string? HitVfx
	{
		[CompilerGenerated]
		get;
	}

	public extern AttackCommand(decimal damagePerHit);

	public extern AttackCommand(CalculatedDamageVar calculatedDamageVar);

	public extern AttackCommand FromCard(CardModel card);

	public extern AttackCommand FromOsty(Creature osty, CardModel card);

	public extern AttackCommand FromMonster(MonsterModel monster);

	public extern AttackCommand Targeting(Creature target);

	public extern AttackCommand TargetingAllOpponents(CombatState combatState);

	public extern AttackCommand TargetingRandomOpponents(CombatState combatState, bool allowDuplicates = true);

	public extern AttackCommand Unpowered();

	public extern AttackCommand WithAttackerAnim(string? animName, float delay, Creature? visualAttacker = null);

	public extern AttackCommand WithNoAttackerAnim();

	public extern AttackCommand AfterAttackerAnim(Func<Task> afterAttackerAnim);

	public extern AttackCommand WithAttackerFx(string? vfx = null, string? sfx = null, string? tmpSfx = null);

	public extern AttackCommand WithAttackerFx(Func<Node2D?> createAttackerVfx);

	public extern AttackCommand WithWaitBeforeHit(float fastSeconds, float standardSeconds);

	public extern AttackCommand WithHitFx(string? vfx = null, string? sfx = null, string? tmpSfx = null);

	public extern AttackCommand SpawningHitVfxOnEachCreature();

	public extern AttackCommand WithHitVfxSpawnedAtBase();

	public extern AttackCommand WithHitVfxNode(Func<Creature, Node2D?> createHitVfxNode);

	public extern AttackCommand OnlyPlayAnimOnce();

	public extern AttackCommand WithHitCount(int hitCount);

	public extern AttackCommand BeforeDamage(Func<Task> beforeDamage);

	[AsyncStateMachine(typeof(_003CCreateContextAsync_003Ed__85))]
	public static extern Task<AttackContext> CreateContextAsync(CombatState combatState, CardModel cardSource);

	[AsyncStateMachine(typeof(_003CExecute_003Ed__86))]
	public extern Task<AttackCommand> Execute(PlayerChoiceContext? choiceContext);

	public extern void IncrementHitsInternal();

	public extern void AddResultsInternal(IEnumerable<DamageResult> results);
}
