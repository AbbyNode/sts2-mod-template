using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Ancients;

public class AncientDialogue
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<AncientDialogueLine> Lines
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsRepeating
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int? VisitIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern ArchitectAttackers StartAttackers
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern ArchitectAttackers EndAttackers
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern AncientDialogue(params string[] sfxPaths);

	public extern void PopulateLines(string ancientEntry, string charEntry, int dialogueIndex);
}
