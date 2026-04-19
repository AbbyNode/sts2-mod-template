using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableCard : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("id")]
	public extern ModelId? Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("current_upgrade_level")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern int CurrentUpgradeLevel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("enchantment")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern SerializableEnchantment? Enchantment
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("props")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern SavedProperties? Props
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("floor_added_to_deck")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern int? FloorAddedToDeck
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern bool Equals(object? obj);

	public override extern int GetHashCode();

	public override extern string ToString();

	public extern SerializableCard();
}
