using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Models.CardPools;

public sealed class MockCardPool : CardPoolModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string Title { get; }

	public override extern string EnergyColorName { get; }

	public override extern string CardFrameMaterialPath { get; }

	public override extern Color DeckEntryCardColor { get; }

	public override extern bool IsColorless { get; }

	public override extern IEnumerable<CardModel> AllCards { get; }

	public extern void Add(CardModel card);

	public extern MockCardPool();
}
