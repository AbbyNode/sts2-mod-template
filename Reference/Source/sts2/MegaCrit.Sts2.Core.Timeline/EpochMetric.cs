using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Timeline;

public class EpochMetric
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("buildId")]
	public required extern string BuildId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("epoch")]
	public required extern string Epoch
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("totalEpochs")]
	public extern int TotalEpochs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("totalPlaytime")]
	public extern long TotalPlaytime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("totalRuns")]
	public extern int TotalRuns
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern EpochMetric();
}
