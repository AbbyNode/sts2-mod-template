using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.DevConsole;

public class CompletionResult
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern List<string> Candidates
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string CommonPrefix
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool HasMultipleMatches { get; }

	public extern CompletionType Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string CommandPrefix
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int ArgumentIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string ArgumentContext
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CompletionResult();
}
