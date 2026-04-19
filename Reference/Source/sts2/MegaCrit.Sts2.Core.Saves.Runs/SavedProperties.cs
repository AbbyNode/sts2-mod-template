using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

[Serializable]
public class SavedProperties : IPacketSerializable
{
	public struct SavedProperty<T>
	{
		public string name;

		public T value;

		public extern SavedProperty(string name, T value);
	}

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("ints")]
	public List<SavedProperty<int>>? ints;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("bools")]
	public List<SavedProperty<bool>>? bools;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("strings")]
	public List<SavedProperty<string>>? strings;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("int_arrays")]
	public List<SavedProperty<int[]>>? intArrays;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("model_ids")]
	public List<SavedProperty<ModelId>>? modelIds;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("cards")]
	public List<SavedProperty<SerializableCard>>? cards;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("card_arrays")]
	public List<SavedProperty<SerializableCard[]>>? cardArrays;

	public extern SavedProperties();

	public static extern SavedProperties? From(AbstractModel model);

	public static extern SavedProperties? FromInternal(object model, ModelId? id);

	public extern void Fill(AbstractModel model);

	[UnconditionalSuppressMessage("AOT", "IL3050", Justification = "We only create array types that are referenced by SavedProperties that already exist in code.")]
	public extern void FillInternal(object model);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
