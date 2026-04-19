using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs.History;

public class MapPointHistoryEntry : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("map_point_type")]
	public extern MapPointType MapPointType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("rooms")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<MapPointRoomHistoryEntry> Rooms
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("player_stats")]
	public extern List<PlayerMapPointHistoryEntry> PlayerStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern MapPointHistoryEntry();

	public extern MapPointHistoryEntry(MapPointType mapPointType, IPlayerCollection playerCollection);

	public extern PlayerMapPointHistoryEntry GetEntry(ulong playerId);

	public extern bool HasRoomOfType(RoomType roomType);

	[IteratorStateMachine(typeof(_003CGetRoomsOfType_003Ed__16))]
	public extern IEnumerable<MapPointRoomHistoryEntry> GetRoomsOfType(RoomType roomType);

	public extern MapPointRoomHistoryEntry? FirstRoomOfType(RoomType roomType);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern MapPointHistoryEntry Anonymized();
}
