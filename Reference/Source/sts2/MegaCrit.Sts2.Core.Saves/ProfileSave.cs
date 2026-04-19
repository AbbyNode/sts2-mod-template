using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves;

public class ProfileSave : ISaveSchema
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("schema_version")]
	public extern int SchemaVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("last_profile_id")]
	public extern int LastProfileId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern ProfileSave();
}
