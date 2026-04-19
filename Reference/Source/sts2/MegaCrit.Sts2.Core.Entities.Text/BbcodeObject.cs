using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MegaCrit.Sts2.Core.Entities.Text;

public record BbcodeObject
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	public BbcodeObjectType type;

	public string? text;

	public string? tag;

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(BbcodeObject? other);

	[CompilerGenerated]
	protected extern BbcodeObject(BbcodeObject original);

	public extern BbcodeObject();
}
