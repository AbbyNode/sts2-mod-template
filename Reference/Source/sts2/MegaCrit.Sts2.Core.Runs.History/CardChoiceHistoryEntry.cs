using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs.History;

[Serializable]
public struct CardChoiceHistoryEntry
{
	[JsonPropertyName("was_picked")]
	public bool wasPicked;

	[JsonPropertyName("card")]
	public extern SerializableCard Card
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern CardChoiceHistoryEntry(CardModel card, bool wasPicked);

	public extern void Serialize<T>(PacketWriter writer) where T : AbstractModel;

	public extern void Deserialize<T>(PacketReader reader) where T : AbstractModel;
}
