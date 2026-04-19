using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Localization;

public class LocStringVariablesJsonConverter : JsonConverter<Dictionary<string, object>>
{
	public override extern Dictionary<string, object> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

	public override extern void Write(Utf8JsonWriter writer, Dictionary<string, object> varDict, JsonSerializerOptions options);

	public extern LocStringVariablesJsonConverter();
}
