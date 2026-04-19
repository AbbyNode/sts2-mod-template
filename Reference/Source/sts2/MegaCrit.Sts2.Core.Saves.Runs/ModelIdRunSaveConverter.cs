using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class ModelIdRunSaveConverter : JsonConverter<ModelId>
{
	public override extern ModelId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

	public override extern void Write(Utf8JsonWriter writer, ModelId value, JsonSerializerOptions options);

	public extern ModelIdRunSaveConverter();
}
