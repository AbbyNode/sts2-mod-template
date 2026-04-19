using System;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves;

public class SnakeCaseJsonStringEnumConverter<TEnum> : JsonStringEnumConverter<TEnum> where TEnum : struct, Enum
{
	public extern SnakeCaseJsonStringEnumConverter();
}
