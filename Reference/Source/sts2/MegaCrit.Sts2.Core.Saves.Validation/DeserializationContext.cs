using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Saves.Validation;

public sealed class DeserializationContext
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<ValidationError> Errors { get; }

	public extern bool HasFatal { get; }

	public extern int WarningCount { get; }

	public extern int FatalCount { get; }

	public extern void PushPath(string segment);

	public extern void PopPath();

	public extern void Warn(string message);

	public extern void Fatal(string message);

	public extern DeserializationContext();
}
