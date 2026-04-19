using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.DevConsole;

public class TabCompletionState
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int SelectionIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<string> CompletionCandidates
	{
		[CompilerGenerated]
		get;
	}

	public extern bool InSelectionMode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool ProgrammaticTextChange
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CompletionResult? LastCompletionResult
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Reset();

	public extern TabCompletionState();
}
