using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public readonly struct CardTransformation
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardModel Original
	{
		[CompilerGenerated]
		get;
	}

	public extern CardModel? Replacement
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<CardModel>? ReplacementOptions
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsInCombat
	{
		[CompilerGenerated]
		get;
	}

	public extern CardTransformation(CardModel original);

	public extern CardTransformation(CardModel original, IEnumerable<CardModel> options);

	public extern CardTransformation(CardModel original, CardModel replacement);

	public extern CardModel? GetReplacement(Rng? rng);

	[IteratorStateMachine(typeof(_003CYield_003Ed__16))]
	public extern IEnumerable<CardTransformation> Yield();
}
