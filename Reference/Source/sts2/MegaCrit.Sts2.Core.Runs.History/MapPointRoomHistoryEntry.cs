using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs.History;

public class MapPointRoomHistoryEntry : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("room_type")]
	public extern RoomType RoomType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("model_id")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotTypeDefault)]
	public extern ModelId? ModelId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("monster_ids")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> MonsterIds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("turns_taken")]
	public extern int TurnsTaken
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern MapPointRoomHistoryEntry();
}
