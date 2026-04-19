using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Saves;

public record SerializableUnlockedAchievement
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	[JsonPropertyName("achievement")]
	public extern string Achievement
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("unlock_time")]
	public extern long UnlockTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(SerializableUnlockedAchievement? other);

	[CompilerGenerated]
	protected extern SerializableUnlockedAchievement(SerializableUnlockedAchievement original);

	public extern SerializableUnlockedAchievement();
}
