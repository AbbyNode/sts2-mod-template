using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Events;

namespace MegaCrit.Sts2.Core.Models.Events;

public class Tanx : AncientEventModel
{
	public override extern Color ButtonColor { get; }

	public override extern Color DialogueColor { get; }

	public override extern IEnumerable<EventOption> AllPossibleOptions { get; }

	protected override extern AncientDialogueSet DefineDialogues();

	protected override extern IReadOnlyList<EventOption> GenerateInitialOptions();

	public extern Tanx();
}
