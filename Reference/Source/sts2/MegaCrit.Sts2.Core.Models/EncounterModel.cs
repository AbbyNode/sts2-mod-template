using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Encounters;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.Rooms;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class EncounterModel : AbstractModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool ShouldReceiveCombatHooks { get; }

	protected extern Rng Rng { get; }

	public abstract RoomType RoomType { get; }

	public virtual extern bool IsWeak { get; }

	public virtual extern bool ShouldGiveRewards { get; }

	public virtual extern int MinGoldReward { get; }

	public virtual extern int MaxGoldReward { get; }

	public extern LocString? CustomRewardDescription { get; }

	public virtual extern bool IsDebugEncounter { get; }

	public virtual extern IEnumerable<EncounterTag> Tags { get; }

	public extern bool HaveMonstersBeenGenerated { get; }

	public extern IReadOnlyList<(MonsterModel, string?)> MonstersWithSlots { get; }

	public abstract IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern EncounterModel CanonicalInstance { get; }

	public virtual extern bool HasScene { get; }

	public virtual extern IReadOnlyList<string> Slots { get; }

	public virtual extern bool FullyCenterPlayers { get; }

	protected virtual extern bool HasCustomBackground { get; }

	public virtual extern string CustomBgm { get; }

	public extern bool HasBgm { get; }

	public virtual extern string AmbientSfx { get; }

	public extern bool HasAmbientSfx { get; }

	public virtual extern string BossNodePath { get; }

	public virtual extern MegaSkeletonDataResource? BossNodeSpineResource { get; }

	public extern LocString Title { get; }

	public extern IEnumerable<string> MapNodeAssetPaths { get; }

	public virtual extern IEnumerable<string>? ExtraAssetPaths { get; }

	public virtual extern float GetCameraScaling();

	public virtual extern Vector2 GetCameraOffset();

	public extern string GetNextSlot(CombatState combatState);

	protected abstract IReadOnlyList<(MonsterModel, string?)> GenerateMonsters();

	public extern void GenerateMonstersWithSlots(IRunState runState);

	public extern bool SharesTagsWith(EncounterModel? other);

	public extern NCombatBackground CreateBackground(ActModel parentAct, Rng rng);

	public extern Control CreateScene();

	public extern EncounterModel ToMutable();

	public extern IEnumerable<string> GetAssetPaths(IRunState runState);

	public extern void DebugRandomizeRng();

	public extern LocString GetLossMessageFor(CharacterModel character);

	public virtual extern Dictionary<string, string> SaveCustomState();

	public virtual extern void LoadCustomState(Dictionary<string, string> state);

	protected extern EncounterModel();
}
