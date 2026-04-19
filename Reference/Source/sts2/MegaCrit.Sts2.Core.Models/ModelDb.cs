using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.Models;

public static class ModelDb
{
	public static extern Type[] AllAbstractModelSubtypes { get; }

	public static extern IEnumerable<AfflictionModel> DebugAfflictions { get; }

	public static extern IEnumerable<EnchantmentModel> DebugEnchantments { get; }

	public static extern IEnumerable<CardModel> AllCards { get; }

	public static extern IEnumerable<CardPoolModel> AllCardPools { get; }

	public static extern IEnumerable<CardPoolModel> AllSharedCardPools { get; }

	public static extern IEnumerable<CardPoolModel> AllCharacterCardPools { get; }

	public static extern IEnumerable<CharacterModel> AllCharacters { get; }

	public static extern IEnumerable<EventModel> AllSharedEvents { get; }

	public static extern IEnumerable<AncientEventModel> AllAncients { get; }

	public static extern IEnumerable<AncientEventModel> AllSharedAncients { get; }

	public static extern IEnumerable<EventModel> AllEvents { get; }

	public static extern IEnumerable<MonsterModel> Monsters { get; }

	public static extern IEnumerable<EncounterModel> AllEncounters { get; }

	public static extern IEnumerable<PotionModel> AllPotions { get; }

	public static extern IEnumerable<PotionPoolModel> AllPotionPools { get; }

	public static extern IEnumerable<PotionPoolModel> AllCharacterPotionPools { get; }

	public static extern IEnumerable<RelicPoolModel> AllCharacterRelicPools { get; }

	public static extern IEnumerable<PowerModel> AllPowers { get; }

	public static extern IEnumerable<RelicModel> AllRelics { get; }

	public static extern IEnumerable<RelicPoolModel> AllRelicPools { get; }

	public static extern IEnumerable<RelicPoolModel> CharacterRelicPools { get; }

	public static extern IEnumerable<OrbModel> Orbs { get; }

	public static extern IEnumerable<ActModel> Acts { get; }

	public static extern IReadOnlyList<AchievementModel> Achievements { get; }

	public static extern IReadOnlyList<ModifierModel> GoodModifiers { get; }

	public static extern IReadOnlyList<ModifierModel> BadModifiers { get; }

	public static extern IReadOnlyList<IReadOnlySet<ModifierModel>> MutuallyExclusiveModifiers { get; }

	public static extern void Init();

	public static extern void Inject([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type type);

	public static extern void Remove(Type type);

	public static extern void InitIds();

	public static extern void Preload();

	public static extern ModelId GetId<T>() where T : AbstractModel;

	public static extern ModelId GetId(Type type);

	public static extern Type GetCategoryType(Type type);

	public static extern string GetCategory(Type type);

	public static extern string GetEntry(Type type);

	public static extern T? GetByIdOrNull<T>(ModelId id) where T : AbstractModel;

	public static extern T GetById<T>(ModelId id) where T : AbstractModel;

	public static extern bool Contains(Type type);

	public static extern T Affliction<T>() where T : AfflictionModel;

	public static extern T Enchantment<T>() where T : EnchantmentModel;

	public static extern T Card<T>() where T : CardModel;

	public static extern T CardPool<T>() where T : CardPoolModel;

	public static extern T Character<T>() where T : CharacterModel;

	public static extern T Event<T>() where T : EventModel;

	public static extern T AncientEvent<T>() where T : AncientEventModel;

	public static extern T Monster<T>() where T : MonsterModel;

	public static extern T Encounter<T>() where T : EncounterModel;

	public static extern T Potion<T>() where T : PotionModel;

	public static extern T PotionPool<T>() where T : PotionPoolModel;

	public static extern T Power<T>() where T : PowerModel;

	public static extern PowerModel DebugPower(Type type);

	public static extern T Relic<T>() where T : RelicModel;

	public static extern T RelicPool<T>() where T : RelicPoolModel;

	public static extern T Orb<T>() where T : OrbModel;

	public static extern OrbModel? DebugOrb(Type type);

	public static extern T Act<T>() where T : ActModel;

	public static extern T Singleton<T>() where T : SingletonModel;

	public static extern T Achievement<T>() where T : AchievementModel;

	public static extern T Modifier<T>() where T : ModifierModel;
}
