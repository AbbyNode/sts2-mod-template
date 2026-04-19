using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Achievements;

public class AchievementMetric
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

	[JsonPropertyName("achievement")]
	public required extern string Achievement
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("totalAchievements")]
	public extern int TotalAchievements
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

	public extern AchievementMetric();
}
