using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Saves;

public class ReadSaveResult<T> where T : ISaveSchema
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern T? SaveData
	{
		[CompilerGenerated]
		get;
	}

	public extern ReadSaveStatus Status
	{
		[CompilerGenerated]
		get;
	}

	public extern bool Success { get; }

	public extern string? ErrorMessage
	{
		[CompilerGenerated]
		get;
	}

	public extern ReadSaveResult(T data);

	public extern ReadSaveResult(ReadSaveStatus status, string? errorMessage = null);

	public extern ReadSaveResult(T data, ReadSaveStatus status, string? errorMessage = null);
}
