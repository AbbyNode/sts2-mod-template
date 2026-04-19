using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public sealed class CardEnergyCost
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Canonical
	{
		[CompilerGenerated]
		get;
	}

	public extern bool CostsX
	{
		[CompilerGenerated]
		get;
	}

	public extern bool WasJustUpgraded
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasLocalModifiers { get; }

	public extern int CapturedXValue { get; set; }

	public extern CardEnergyCost(CardModel card, int canonicalCost, bool costsX);

	public extern int GetWithModifiers(CostModifiers modifiers);

	public extern int GetAmountToSpend();

	public extern int GetResolved();

	public extern void SetUntilPlayed(int cost, bool reduceOnly = false);

	public extern void SetThisTurnOrUntilPlayed(int cost, bool reduceOnly = false);

	public extern void SetThisTurn(int cost, bool reduceOnly = false);

	public extern void SetThisCombat(int cost, bool reduceOnly = false);

	public extern void AddUntilPlayed(int amount, bool reduceOnly = false);

	public extern void AddThisTurnOrUntilPlayed(int amount, bool reduceOnly = false);

	public extern void AddThisTurn(int amount, bool reduceOnly = false);

	public extern void AddThisCombat(int amount, bool reduceOnly = false);

	public extern bool EndOfTurnCleanup();

	public extern bool AfterCardPlayedCleanup();

	public extern void UpgradeBy(int addend);

	public extern void FinalizeUpgrade();

	public extern void ResetForDowngrade();

	public extern void SetCustomBaseCost(int newBaseCost);

	public extern CardEnergyCost Clone(CardModel newCard);
}
