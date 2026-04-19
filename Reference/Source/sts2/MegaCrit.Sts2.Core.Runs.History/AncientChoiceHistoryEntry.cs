using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Runs.History;

[Serializable]
public class AncientChoiceHistoryEntry : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("title")]
	public extern LocString Title
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("was_chosen")]
	public extern bool WasChosen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("TextKey")]
	public extern string TextKey { get; }

	public extern AncientChoiceHistoryEntry();

	public extern AncientChoiceHistoryEntry(LocString title, bool wasChosen);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
