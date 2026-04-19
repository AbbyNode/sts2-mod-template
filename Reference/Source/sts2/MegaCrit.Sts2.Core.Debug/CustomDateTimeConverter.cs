using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Debug;

public class CustomDateTimeConverter : JsonConverter<DateTime>
{
	public override extern DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

	public override extern void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options);

	public extern CustomDateTimeConverter();
}
