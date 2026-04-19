using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MegaCrit.Sts2.Core.Localization;

public record LocValidationError
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	public extern string FilePath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern string Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern string ErrorMessage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocValidationError(string FilePath, string Key, string ErrorMessage);

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(LocValidationError? other);

	[CompilerGenerated]
	protected extern LocValidationError(LocValidationError original);

	[CompilerGenerated]
	public extern void Deconstruct(out string FilePath, out string Key, out string ErrorMessage);
}
