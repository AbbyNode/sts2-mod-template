using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableExtraRunFields : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("started_with_neow")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern bool StartedWithNeow
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("test_subject_kills")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern int TestSubjectKills
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("freed_repy")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern bool FreedRepy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableExtraRunFields();
}
