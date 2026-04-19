using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards.Mocks;

public abstract class MockCardModel : CardModel
{
	protected int _mockEnergyCost;

	protected CardMultiplayerConstraint _mockMultiplayerConstraint;

	protected bool _mockEnergyCostX;

	protected int _mockStarCost;

	protected bool _mockStarCostX;

	protected Func<CardModel, Task>? _mockExtraLogic;

	protected int _mockMaxUpgradeLevel;

	protected CardRarity _mockRarity;

	protected int _mockSelfHpLoss;

	protected HashSet<CardTag>? _mockTags;

	protected CardPoolModel? _mockPool;

	protected Action<CardModel>? _mockUpgradeLogic;

	protected override extern int CanonicalEnergyCost { get; }

	protected override extern bool HasEnergyCostX { get; }

	public override extern int CanonicalStarCost { get; }

	public override extern bool HasStarCostX { get; }

	public override extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public override extern bool GainsBlock { get; }

	public override extern int MaxUpgradeLevel { get; }

	public override extern CardRarity Rarity { get; }

	public override extern CardPoolModel Pool { get; }

	public override extern IEnumerable<CardTag> Tags { get; }

	protected extern MockCardModel();

	public abstract MockCardModel MockBlock(int block);

	public extern MockCardModel MockCanonical();

	public extern MockCardModel MockEnergyCost(int cost);

	public extern MockCardModel MockMultiplayerType(CardMultiplayerConstraint constraint);

	public extern MockCardModel MockEnergyCostX();

	public extern MockCardModel MockStarCost(int cost);

	public extern MockCardModel MockStarCostX();

	public extern MockCardModel MockExtraLogic(Func<CardModel, Task> extraLogic);

	public extern MockCardModel MockKeyword(CardKeyword keyword);

	public extern MockCardModel MockReplay(int count);

	public extern MockCardModel MockRarity(CardRarity rarity);

	public extern MockCardModel MockPool<T>() where T : CardPoolModel;

	public extern MockCardModel MockTag(CardTag tag);

	public extern MockCardModel MockSelfHpLoss(int hpLoss);

	public extern MockCardModel MockUnUpgradable();

	public extern MockCardModel MockUpgradeLogic(Action<CardModel> upgradeLogic);

	protected abstract int GetBaseBlock();
}
