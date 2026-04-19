using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializablePlayer : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("character_id")]
	public extern ModelId? CharacterId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("current_hp")]
	public extern int CurrentHp
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("max_hp")]
	public extern int MaxHp
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("max_energy")]
	public extern int MaxEnergy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("max_potion_slot_count")]
	public extern int MaxPotionSlotCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("gold")]
	public extern int Gold
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("base_orb_slot_count")]
	public extern int BaseOrbSlotCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("net_id")]
	public extern ulong NetId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("deck")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<SerializableCard> Deck
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("relics")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<SerializableRelic> Relics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("potions")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<SerializablePotion> Potions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("rng")]
	public extern SerializablePlayerRngSet Rng
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("odds")]
	public extern SerializablePlayerOddsSet Odds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("relic_grab_bag")]
	public extern SerializableRelicGrabBag RelicGrabBag
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("extra_fields")]
	public extern SerializableExtraPlayerFields ExtraFields
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("unlock_state")]
	public extern SerializableUnlockState UnlockState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_cards")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> DiscoveredCards
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_enemies")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> DiscoveredEnemies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_epochs")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	[JsonConverter(typeof(EpochIdListConverter))]
	public extern List<string> DiscoveredEpochs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_potions")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> DiscoveredPotions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_relics")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> DiscoveredRelics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializablePlayer Anonymized();

	public extern SerializablePlayer();
}
