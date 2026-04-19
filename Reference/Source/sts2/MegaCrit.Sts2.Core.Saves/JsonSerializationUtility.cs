using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Saves;

public static class JsonSerializationUtility
{
	public static extern IJsonTypeInfoResolver DefaultResolver
	{
		[CompilerGenerated]
		get;
	}

	public static extern JsonSerializerOptions Options
	{
		[CompilerGenerated]
		get;
	}

	public static extern void AddTypeInfoResolver(IJsonTypeInfoResolver resolver);

	[AsyncStateMachine(typeof(_003CSerializeAsync_003Ed__7<>))]
	public static extern Task<string> SerializeAsync<T>(T data) where T : ISaveSchema;

	public static extern JsonTypeInfo<T> GetTypeInfo<T>(T value);

	public static extern JsonTypeInfo<T> GetTypeInfo<T>();

	public static extern void AlphabetizeProperties(JsonTypeInfo info);

	public static extern string ToJson<T>(T obj) where T : ISaveSchema;

	public static extern ReadSaveResult<T> FromJson<T>(string json) where T : ISaveSchema, new();
}
