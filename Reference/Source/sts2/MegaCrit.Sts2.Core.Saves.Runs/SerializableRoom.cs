using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableRoom : IPacketSerializable
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

	[JsonPropertyName("encounter_id")]
	public extern ModelId? EncounterId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("event_id")]
	public extern ModelId? EventId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("is_pre_finished")]
	public extern bool IsPreFinished
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("reward_proportion")]
	public extern float GoldProportion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("extra_rewards")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern Dictionary<ulong, List<SerializableReward>> ExtraRewards
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("parent_event_id")]
	public extern ModelId? ParentEventId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("should_resume_parent_event")]
	public extern bool ShouldResumeParentEvent
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("encounter_state")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern Dictionary<string, string> EncounterState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableRoom();
}
