using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Entities.Creatures;

public class Creature
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Block { get; }

	public extern int CurrentHp { get; }

	public extern int MaxHp { get; }

	public extern int? MonsterMaxHpBeforeModification
	{
		[CompilerGenerated]
		get;
	}

	public extern uint? CombatId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern MonsterModel? Monster
	{
		[CompilerGenerated]
		get;
	}

	public extern Player? Player
	{
		[CompilerGenerated]
		get;
	}

	public extern ModelId ModelId { get; }

	public extern CombatSide Side
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatState? CombatState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string Name { get; }

	public extern bool IsMonster { get; }

	public extern bool IsPlayer { get; }

	public extern bool ShowsInfiniteHp
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern Player? PetOwner { get; set; }

	public extern bool IsPet { get; }

	public extern IReadOnlyList<Creature> Pets { get; }

	public extern bool IsAlive { get; }

	public extern bool IsDead { get; }

	public extern string? SlotName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern bool IsEnemy { get; }

	public extern bool IsPrimaryEnemy { get; }

	public extern bool IsSecondaryEnemy { get; }

	public extern bool IsHittable { get; }

	public extern bool CanReceivePowers { get; }

	public extern bool IsStunned { get; }

	public extern IReadOnlyList<PowerModel> Powers { get; }

	public extern event Action<int, int>? BlockChanged;

	public extern event Action<int, int>? CurrentHpChanged;

	public extern event Action<int, int>? MaxHpChanged;

	public extern event Action<PowerModel>? PowerApplied;

	public extern event Action<PowerModel, int, bool>? PowerIncreased;

	public extern event Action<PowerModel, bool>? PowerDecreased;

	public extern event Action<PowerModel>? PowerRemoved;

	public extern event Action<Creature>? Died;

	public extern event Action<Creature>? Revived;

	public extern Creature(MonsterModel monster, CombatSide side, string? slotName);

	public extern Creature(Player player, int currentHp, int maxHp);

	public extern void SetUniqueMonsterHpValue(IReadOnlyList<Creature> creaturesOnSide, Rng rng);

	public extern void ScaleMonsterHpForMultiplayer(EncounterModel? encounter, int playerCount, int actIndex);

	public extern NCreatureVisuals? CreateVisuals();

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__108))]
	public extern Task AfterAddedToRoom();

	public extern decimal DamageBlockInternal(decimal amount, ValueProp props);

	public extern DamageResult LoseHpInternal(decimal amount, ValueProp props);

	public extern void GainBlockInternal(decimal amount);

	public extern void LoseBlockInternal(decimal amount);

	public extern void HealInternal(decimal amount);

	public extern void SetCurrentHpInternal(decimal amount);

	public extern void SetMaxHpInternal(decimal amount);

	public extern void Reset();

	public extern void InvokeDiedEvent();

	public extern void StunInternal(Func<IReadOnlyList<Creature>, Task> stunMove, string? nextMoveId);

	public extern void PrepareForNextTurn(IEnumerable<Creature> targets, bool rollNewMove = true);

	public extern bool HasPower<T>() where T : PowerModel;

	public extern bool HasPower(ModelId id);

	public extern T? GetPower<T>() where T : PowerModel;

	public extern PowerModel? GetPower(ModelId id);

	public extern IEnumerable<T> GetPowerInstances<T>() where T : PowerModel;

	public extern PowerModel? GetPowerById(ModelId id);

	public extern int GetPowerAmount<T>() where T : PowerModel;

	public extern void ApplyPowerInternal(PowerModel power);

	public extern void InvokePowerModified(PowerModel power, int change, bool silent);

	public extern void RemovePowerInternal(PowerModel power);

	public extern IEnumerable<PowerModel> RemoveAllPowersInternalExcept(IEnumerable<PowerModel>? except = null);

	public extern IEnumerable<PowerModel> RemoveAllPowersAfterDeath();

	public extern void BeforeTurnStart(int roundNumber, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterTurnStart_003Ed__135))]
	public extern Task AfterTurnStart(int roundNumber, CombatSide side);

	public extern void OnSideSwitch();

	[AsyncStateMachine(typeof(_003CTakeTurn_003Ed__137))]
	public extern Task TakeTurn();

	public override extern string ToString();

	public extern double GetHpPercentRemaining();

	public static extern decimal ScaleHpForMultiplayer(decimal hp, EncounterModel? encounter, int playerCount, int actIndex);
}
