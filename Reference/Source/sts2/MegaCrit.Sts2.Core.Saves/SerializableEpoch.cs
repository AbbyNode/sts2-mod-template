using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves;

public class SerializableEpoch
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("id")]
	public extern string Id
	{
		[CompilerGenerated]
		get;
	}

	[JsonPropertyName("state")]
	public extern EpochState State
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("obtain_date")]
	public extern long ObtainDate
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SerializableEpoch(string id, EpochState state);

	public extern void SetObtained(EpochState state);
}
