using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class EpochIdListConverter : JsonConverter<List<string>>
{
	public override extern List<string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

	public override extern void Write(Utf8JsonWriter writer, List<string> value, JsonSerializerOptions options);

	public extern EpochIdListConverter();
}
