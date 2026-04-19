using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public record ConnectionFailureExtraInfo
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	public List<string>? missingModsOnLocal;

	public List<string>? missingModsOnHost;

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(ConnectionFailureExtraInfo? other);

	[CompilerGenerated]
	protected extern ConnectionFailureExtraInfo(ConnectionFailureExtraInfo original);

	public extern ConnectionFailureExtraInfo();
}
