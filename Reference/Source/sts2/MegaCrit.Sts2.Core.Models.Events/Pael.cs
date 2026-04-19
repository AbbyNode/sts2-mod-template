using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Events;

namespace MegaCrit.Sts2.Core.Models.Events;

public class Pael : AncientEventModel
{
	public override extern IEnumerable<EventOption> AllPossibleOptions { get; }

	public override extern Color ButtonColor { get; }

	public override extern Color DialogueColor { get; }

	protected override extern AncientDialogueSet DefineDialogues();

	protected override extern IReadOnlyList<EventOption> GenerateInitialOptions();

	public extern Pael();
}
