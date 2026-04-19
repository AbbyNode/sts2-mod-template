using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ArchaicTooth : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern List<CardModel> TranscendenceCards { get; }

	public override extern RelicRarity Rarity { get; }

	[SavedProperty]
	public extern SerializableCard? StarterCard { get; }

	[SavedProperty]
	public extern SerializableCard? AncientCard { get; }

	public extern bool SetupForPlayer(Player player);

	public extern void SetupForTests(SerializableCard starterCard, SerializableCard ancientCard);

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__27))]
	public override extern Task AfterObtained();

	public extern ArchaicTooth();
}
