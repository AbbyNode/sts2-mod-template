using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Ancients;

public class AncientDialogueSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public required extern AncientDialogue? FirstVisitEverDialogue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern Dictionary<string, IReadOnlyList<AncientDialogue>> CharacterDialogues
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern IReadOnlyList<AncientDialogue> AgnosticDialogues
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[IteratorStateMachine(typeof(_003CGetAllDialogues_003Ed__12))]
	public extern IEnumerable<AncientDialogue> GetAllDialogues();

	public extern IEnumerable<AncientDialogue> GetValidDialogues(ModelId characterId, int charVisits, int totalVisits, bool allowAnyCharacterDialogues);

	public extern void PopulateLocKeys(string ancientEntry);

	public extern AncientDialogueSet();
}
