using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.CardSelection;

public struct CardSelectorPrefs
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern LocString TransformSelectionPrompt { get; }

	public static extern LocString ExhaustSelectionPrompt { get; }

	public static extern LocString RemoveSelectionPrompt { get; }

	public static extern LocString EnchantSelectionPrompt { get; }

	public static extern LocString DiscardSelectionPrompt { get; }

	public static extern LocString UpgradeSelectionPrompt { get; }

	public readonly extern LocString Prompt
	{
		[CompilerGenerated]
		get;
	}

	public readonly extern int MinSelect
	{
		[CompilerGenerated]
		get;
	}

	public readonly extern int MaxSelect
	{
		[CompilerGenerated]
		get;
	}

	public extern bool RequireManualConfirmation
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public extern bool Cancelable
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public extern bool UnpoweredPreviews
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public extern bool PretendCardsCanBePlayed
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public extern Func<CardModel, bool>? ShouldGlowGold
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern CardSelectorPrefs(LocString prompt, int selectCount);

	public extern CardSelectorPrefs(LocString prompt, int minCount, int maxCount);
}
