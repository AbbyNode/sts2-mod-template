using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class TheArchitect : EventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern EventLayoutType LayoutType { get; }

	public override extern EncounterModel CanonicalEncounter { get; }

	public override extern string LocTable { get; }

	public override extern IEnumerable<LocString> GameInfoOptions { get; }

	public extern AncientDialogueSet DialogueSet { get; }

	public override extern void OnRoomEnter();

	public extern void TriggerVictory();

	public extern TheArchitect();
}
