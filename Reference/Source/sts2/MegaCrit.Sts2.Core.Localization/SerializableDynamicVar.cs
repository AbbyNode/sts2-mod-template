using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Localization;

public struct SerializableDynamicVar : IPacketSerializable
{
	[JsonPropertyName("type")]
	public DynamicVarType type;

	[JsonPropertyName("decimal_value")]
	public decimal decimalValue;

	[JsonPropertyName("bool_value")]
	public bool boolValue;

	[JsonPropertyName("string_value")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotTypeDefault)]
	public string? stringValue;

	public extern object ToDynamicVar(string name);

	public static extern SerializableDynamicVar? FromDynamicVar(object var);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
