using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves.MapDrawing;

public class SerializableMapDrawingsJsonConverter : JsonConverter<SerializableMapDrawings>
{
	public override extern SerializableMapDrawings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

	public override extern void Write(Utf8JsonWriter writer, SerializableMapDrawings mapDrawings, JsonSerializerOptions options);

	public extern SerializableMapDrawingsJsonConverter();
}
