using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class CardPlay
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public required extern CardModel Card
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern Creature? Target
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern PileType ResultPile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern ResourceInfo Resources
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern bool IsAutoPlay
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern int PlayIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern int PlayCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern bool IsFirstInSeries { get; }

	public extern bool IsLastInSeries { get; }

	public extern CardPlay();
}
