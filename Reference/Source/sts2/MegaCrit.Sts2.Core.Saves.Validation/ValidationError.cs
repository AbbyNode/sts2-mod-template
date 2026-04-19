using System;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Saves.Validation;

public sealed class ValidationError : IEquatable<ValidationError>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValidationSeverity Severity
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern string Message
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern bool IsFatal { get; }

	public extern ValidationError(ValidationSeverity Severity, string Path, string Message);

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	public static extern bool operator !=(ValidationError? left, ValidationError? right);

	[CompilerGenerated]
	public static extern bool operator ==(ValidationError? left, ValidationError? right);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public override extern bool Equals(object? obj);

	[CompilerGenerated]
	public extern bool Equals(ValidationError? other);

	[CompilerGenerated]
	public extern void Deconstruct(out ValidationSeverity Severity, out string Path, out string Message);
}
