using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class RunHistoryPlayer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("id")]
	public extern ulong Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("character")]
	public extern ModelId Character
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("deck")]
	public extern IEnumerable<SerializableCard> Deck
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("relics")]
	public extern IEnumerable<SerializableRelic> Relics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("potions")]
	public extern IEnumerable<SerializablePotion> Potions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("max_potion_slot_count")]
	public extern int MaxPotionSlotCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern RunHistoryPlayer();
}
