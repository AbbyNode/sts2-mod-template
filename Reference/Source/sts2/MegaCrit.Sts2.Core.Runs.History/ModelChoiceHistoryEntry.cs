using System;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Runs.History;

[Serializable]
public struct ModelChoiceHistoryEntry
{
	[JsonPropertyName("choice")]
	public ModelId choice;

	[JsonPropertyName("was_picked")]
	public bool wasPicked;

	public extern ModelChoiceHistoryEntry(ModelId choice, bool wasPicked);

	public extern void Serialize<T>(PacketWriter writer) where T : AbstractModel;

	public extern void Deserialize<T>(PacketReader reader) where T : AbstractModel;
}
