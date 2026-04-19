using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Debug;

public class ReleaseInfo
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("commit")]
	public required extern string Commit
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("version")]
	public required extern string Version
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("date")]
	[JsonConverter(typeof(CustomDateTimeConverter))]
	public required extern DateTime Date
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("branch")]
	public required extern string Branch
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern ReleaseInfo();
}
