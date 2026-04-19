using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Platform.Null;

public record NullMultiplayerName
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	[JsonPropertyName("net_id")]
	public ulong netId;

	[JsonPropertyName("name")]
	public string name;

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(NullMultiplayerName? other);

	[CompilerGenerated]
	protected extern NullMultiplayerName(NullMultiplayerName original);

	public extern NullMultiplayerName();
}
