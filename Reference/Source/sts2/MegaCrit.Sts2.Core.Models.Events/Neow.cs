using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Events;

public class Neow : AncientEventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string AmbientBgm { get; }

	public override extern Color ButtonColor { get; }

	public override extern Color DialogueColor { get; }

	public override extern LocString InitialDescription { get; }

	public override extern IEnumerable<EventOption> AllPossibleOptions { get; }

	protected override extern AncientDialogueSet DefineDialogues();

	protected override extern IReadOnlyList<EventOption> GenerateInitialOptions();

	public extern Neow();
}
