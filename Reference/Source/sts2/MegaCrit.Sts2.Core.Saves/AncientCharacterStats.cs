using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public class AncientCharacterStats
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("character")]
	public required extern ModelId Character
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("wins")]
	public extern int Wins
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("losses")]
	public extern int Losses
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public extern int Visits { get; }

	public extern AncientCharacterStats();
}
