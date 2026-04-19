using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public class CardStats
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("id")]
	public extern ModelId? Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("times_picked")]
	public extern long TimesPicked
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("times_skipped")]
	public extern long TimesSkipped
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("times_won")]
	public extern long TimesWon
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("times_lost")]
	public extern long TimesLost
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CardStats();
}
