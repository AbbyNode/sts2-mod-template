using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.CardRewardAlternatives;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models;

public abstract class AbstractModel : IComparable<AbstractModel>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ModelId Id
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsMutable
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsCanonical { get; }

	public extern int CategorySortingId
	{
		[CompilerGenerated]
		get;
	}

	public extern int EntrySortingId
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern bool PreviewOutsideOfCombat { get; }

	public abstract bool ShouldReceiveCombatHooks { get; }

	public extern event Action<AbstractModel>? ExecutionFinished;

	protected extern AbstractModel();

	public extern void InitId(ModelId id);

	public virtual extern int CompareTo(AbstractModel? other);

	public extern void AssertMutable();

	public extern void AssertCanonical();

	public extern AbstractModel ClonePreservingMutability();

	public extern AbstractModel MutableClone();

	protected virtual extern void DeepCloneFields();

	protected virtual extern void AfterCloned();

	public extern void InvokeExecutionFinished();

	public virtual extern Task AfterActEntered();

	public virtual extern Task AfterAddToDeckPrevented(CardModel card);

	public virtual extern Task BeforeAttack(AttackCommand command);

	public virtual extern Task AfterAttack(AttackCommand command);

	public virtual extern Task AfterBlockCleared(Creature creature);

	public virtual extern Task BeforeBlockGained(Creature creature, decimal amount, ValueProp props, CardModel? cardSource);

	public virtual extern Task AfterBlockGained(Creature creature, decimal amount, ValueProp props, CardModel? cardSource);

	public virtual extern Task AfterBlockBroken(Creature creature);

	public virtual extern Task AfterCardChangedPiles(CardModel card, PileType oldPileType, AbstractModel? source);

	public virtual extern Task AfterCardChangedPilesLate(CardModel card, PileType oldPileType, AbstractModel? source);

	public virtual extern Task AfterCardDiscarded(PlayerChoiceContext choiceContext, CardModel card);

	public virtual extern Task AfterCardDrawnEarly(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	public virtual extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	public virtual extern Task AfterCardEnteredCombat(CardModel card);

	public virtual extern Task AfterCardGeneratedForCombat(CardModel card, bool addedByPlayer);

	public virtual extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal);

	public virtual extern Task BeforeCardAutoPlayed(CardModel card, Creature? target, AutoPlayType type);

	public virtual extern Task BeforeCardPlayed(CardPlay cardPlay);

	public virtual extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public virtual extern Task AfterCardPlayedLate(PlayerChoiceContext choiceContext, CardPlay cardPlay);

	public virtual extern Task AfterCardRetained(CardModel card);

	public virtual extern Task BeforeCombatStart();

	public virtual extern Task BeforeCombatStartLate();

	public virtual extern Task AfterCombatEnd(CombatRoom room);

	public virtual extern Task AfterCombatVictoryEarly(CombatRoom room);

	public virtual extern Task AfterCombatVictory(CombatRoom room);

	public virtual extern Task AfterCreatureAddedToCombat(Creature creature);

	public virtual extern Task AfterCurrentHpChanged(Creature creature, decimal delta);

	public virtual extern Task AfterDamageGiven(PlayerChoiceContext choiceContext, Creature? dealer, DamageResult result, ValueProp props, Creature target, CardModel? cardSource);

	public virtual extern Task BeforeDamageReceived(PlayerChoiceContext choiceContext, Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern Task AfterDamageReceived(PlayerChoiceContext choiceContext, Creature target, DamageResult result, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern Task AfterDamageReceivedLate(PlayerChoiceContext choiceContext, Creature target, DamageResult result, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern Task BeforeDeath(Creature creature);

	public virtual extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	public virtual extern Task AfterDiedToDoom(PlayerChoiceContext choiceContext, IReadOnlyList<Creature> creatures);

	public virtual extern Task AfterEnergyReset(Player player);

	public virtual extern Task AfterEnergyResetLate(Player player);

	public virtual extern Task AfterEnergySpent(CardModel card, int amount);

	public virtual extern Task BeforeCardRemoved(CardModel card);

	public virtual extern Task BeforeFlush(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task BeforeFlushLate(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task AfterGoldGained(Player player);

	public virtual extern Task BeforeHandDraw(Player player, PlayerChoiceContext choiceContext, CombatState combatState);

	public virtual extern Task BeforeHandDrawLate(Player player, PlayerChoiceContext choiceContext, CombatState combatState);

	public virtual extern Task AfterHandEmptied(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task AfterItemPurchased(Player player, MerchantEntry itemPurchased, int goldSpent);

	public virtual extern Task AfterMapGenerated(ActMap map, int actIndex);

	public virtual extern Task AfterModifyingBlockAmount(decimal modifiedAmount, CardModel? cardSource, CardPlay? cardPlay);

	public virtual extern Task AfterModifyingCardPlayCount(CardModel card);

	public virtual extern Task AfterModifyingCardPlayResultPileOrPosition(CardModel card, PileType pileType, CardPilePosition position);

	public virtual extern Task AfterModifyingOrbPassiveTriggerCount(OrbModel orb);

	public virtual extern Task AfterModifyingCardRewardOptions();

	public virtual extern Task AfterModifyingDamageAmount(CardModel? cardSource);

	public virtual extern Task AfterModifyingHandDraw();

	public virtual extern Task AfterPreventingDraw();

	public virtual extern Task AfterModifyingHpLostBeforeOsty();

	public virtual extern Task AfterModifyingHpLostAfterOsty();

	public virtual extern Task AfterModifyingPowerAmountReceived(PowerModel power);

	public virtual extern Task AfterModifyingPowerAmountGiven(PowerModel power);

	public virtual extern Task AfterModifyingRewards();

	public virtual extern Task BeforeRewardsOffered(Player player, IReadOnlyList<Reward> rewards);

	public virtual extern Task AfterOrbChanneled(PlayerChoiceContext choiceContext, Player player, OrbModel orb);

	public virtual extern Task AfterOrbEvoked(PlayerChoiceContext choiceContext, OrbModel orb, IEnumerable<Creature> targets);

	public virtual extern Task AfterOstyRevived(Creature osty);

	public virtual extern Task BeforePotionUsed(PotionModel potion, Creature? target);

	public virtual extern Task AfterPotionUsed(PotionModel potion, Creature? target);

	public virtual extern Task AfterPotionDiscarded(PotionModel potion);

	public virtual extern Task AfterPotionProcured(PotionModel potion);

	public virtual extern Task BeforePowerAmountChanged(PowerModel power, decimal amount, Creature target, Creature? applier, CardModel? cardSource);

	public virtual extern Task AfterPowerAmountChanged(PowerModel power, decimal amount, Creature? applier, CardModel? cardSource);

	public virtual extern Task AfterPreventingBlockClear(AbstractModel preventer, Creature creature);

	public virtual extern Task AfterPreventingDeath(Creature creature);

	public virtual extern Task AfterRestSiteHeal(Player player, bool isMimicked);

	public virtual extern Task AfterRestSiteSmith(Player player);

	public virtual extern Task AfterRewardTaken(Player player, Reward reward);

	public virtual extern Task BeforeRoomEntered(AbstractRoom room);

	public virtual extern Task AfterRoomEntered(AbstractRoom room);

	public virtual extern Task AfterShuffle(PlayerChoiceContext choiceContext, Player shuffler);

	public virtual extern Task AfterStarsSpent(int amount, Player spender);

	public virtual extern Task AfterStarsGained(int amount, Player gainer);

	public virtual extern Task AfterForge(decimal amount, Player forger, AbstractModel? source);

	public virtual extern Task AfterSummon(PlayerChoiceContext choiceContext, Player summoner, decimal amount);

	public virtual extern Task AfterTakingExtraTurn(Player player);

	public virtual extern Task AfterTargetingBlockedVfx(Creature blocker);

	public virtual extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public virtual extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public virtual extern Task AfterPlayerTurnStartEarly(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task AfterPlayerTurnStart(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task AfterPlayerTurnStartLate(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task BeforePlayPhaseStart(PlayerChoiceContext choiceContext, Player player);

	public virtual extern Task BeforeTurnEndVeryEarly(PlayerChoiceContext choiceContext, CombatSide side);

	public virtual extern Task BeforeTurnEndEarly(PlayerChoiceContext choiceContext, CombatSide side);

	public virtual extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public virtual extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public virtual extern Task AfterTurnEndLate(PlayerChoiceContext choiceContext, CombatSide side);

	public virtual extern int ModifyAttackHitCount(AttackCommand attack, int hitCount);

	public virtual extern decimal ModifyBlockAdditive(Creature target, decimal block, ValueProp props, CardModel? cardSource, CardPlay? cardPlay);

	public virtual extern decimal ModifyBlockMultiplicative(Creature target, decimal block, ValueProp props, CardModel? cardSource, CardPlay? cardPlay);

	public virtual extern int ModifyCardPlayCount(CardModel card, Creature? target, int playCount);

	public virtual extern (PileType, CardPilePosition) ModifyCardPlayResultPileTypeAndPosition(CardModel card, bool isAutoPlay, ResourceInfo resources, PileType pileType, CardPilePosition position);

	public virtual extern int ModifyOrbPassiveTriggerCounts(OrbModel orb, int triggerCount);

	public virtual extern CardCreationOptions ModifyCardRewardCreationOptions(Player player, CardCreationOptions options);

	public virtual extern CardCreationOptions ModifyCardRewardCreationOptionsLate(Player player, CardCreationOptions options);

	public virtual extern decimal ModifyCardRewardUpgradeOdds(Player player, CardModel card, decimal odds);

	public virtual extern decimal ModifyDamageAdditive(Creature? target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyDamageCap(Creature? target, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyDamageMultiplicative(Creature? target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern ActMap ModifyGeneratedMap(IRunState runState, ActMap map, int actIndex);

	public virtual extern ActMap ModifyGeneratedMapLate(IRunState runState, ActMap map, int actIndex);

	public virtual extern decimal ModifyHandDraw(Player player, decimal count);

	public virtual extern decimal ModifyHandDrawLate(Player player, decimal count);

	public virtual extern decimal ModifyHealAmount(Creature creature, decimal amount);

	public virtual extern decimal ModifyHpLostBeforeOsty(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyHpLostBeforeOstyLate(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyHpLostAfterOsty(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyHpLostAfterOstyLate(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public virtual extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public virtual extern IEnumerable<CardModel> ModifyMerchantCardPool(Player player, IEnumerable<CardModel> options);

	public virtual extern CardRarity ModifyMerchantCardRarity(Player player, CardRarity rarity);

	public virtual extern void ModifyMerchantCardCreationResults(Player player, List<CardCreationResult> cards);

	public virtual extern decimal ModifyMerchantPrice(Player player, MerchantEntry entry, decimal cost);

	public virtual extern decimal ModifyOrbValue(Player player, decimal value);

	public virtual extern decimal ModifyPowerAmountGiven(PowerModel power, Creature giver, decimal amount, Creature? target, CardModel? cardSource);

	public virtual extern decimal ModifyRestSiteHealAmount(Creature creature, decimal amount);

	public virtual extern void ModifyShuffleOrder(Player player, List<CardModel> cards, bool isInitialShuffle);

	public virtual extern decimal ModifySummonAmount(Player summoner, decimal amount, AbstractModel? source);

	public virtual extern Creature ModifyUnblockedDamageTarget(Creature target, decimal amount, ValueProp props, Creature? dealer);

	public virtual extern EventModel ModifyNextEvent(EventModel currentEvent);

	public virtual extern IReadOnlySet<RoomType> ModifyUnknownMapPointRoomTypes(IReadOnlySet<RoomType> roomTypes);

	public virtual extern float ModifyOddsIncreaseForUnrolledRoomType(RoomType roomType, float oddsIncrease);

	public virtual extern int ModifyXValue(CardModel card, int originalValue);

	public virtual extern bool TryModifyCardBeingAddedToDeck(CardModel card, out CardModel? newCard);

	public virtual extern bool TryModifyCardBeingAddedToDeckLate(CardModel card, out CardModel? newCard);

	public virtual extern bool TryModifyCardRewardAlternatives(Player player, CardReward cardReward, List<CardRewardAlternative> alternatives);

	public virtual extern bool TryModifyCardRewardOptions(Player player, List<CardCreationResult> cardRewardOptions, CardCreationOptions creationOptions);

	public virtual extern bool TryModifyCardRewardOptionsLate(Player player, List<CardCreationResult> cardRewardOptions, CardCreationOptions creationOptions);

	public virtual extern bool TryModifyEnergyCostInCombat(CardModel card, decimal originalCost, out decimal modifiedCost);

	public virtual extern bool TryModifyStarCost(CardModel card, decimal originalCost, out decimal modifiedCost);

	public virtual extern bool TryModifyPowerAmountReceived(PowerModel canonicalPower, Creature target, decimal amount, Creature? applier, out decimal modifiedAmount);

	public virtual extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);

	public virtual extern bool TryModifyRestSiteHealRewards(Player player, List<Reward> rewards, bool isMimicked);

	public virtual extern bool TryModifyRewards(Player player, List<Reward> rewards, AbstractRoom? room);

	public virtual extern bool TryModifyRewardsLate(Player player, List<Reward> rewards, AbstractRoom? room);

	public virtual extern IReadOnlyList<LocString> ModifyExtraRestSiteHealText(Player player, IReadOnlyList<LocString> currentExtraText);

	public virtual extern bool ShouldAddToDeck(CardModel card);

	public virtual extern bool ShouldAfflict(CardModel card, AfflictionModel affliction);

	public virtual extern bool ShouldAllowAncient(Player player, AncientEventModel ancient);

	public virtual extern bool ShouldAllowHitting(Creature creature);

	public virtual extern bool ShouldAllowTargeting(Creature target);

	public virtual extern bool ShouldAllowSelectingMoreCardRewards(Player player, CardReward cardReward);

	public virtual extern bool ShouldClearBlock(Creature creature);

	public virtual extern bool ShouldDie(Creature creature);

	public virtual extern bool ShouldDieLate(Creature creature);

	public virtual extern bool ShouldDisableRemainingRestSiteOptions(Player player);

	public virtual extern bool ShouldDraw(Player player, bool fromHandDraw);

	public virtual extern bool ShouldEtherealTrigger(CardModel card);

	public virtual extern bool ShouldFlush(Player player);

	public virtual extern bool ShouldGainGold(decimal amount, Player player);

	public virtual extern bool ShouldGainStars(decimal amount, Player player);

	public virtual extern bool ShouldGenerateTreasure(Player player);

	public virtual extern bool ShouldPayExcessEnergyCostWithStars(Player player);

	public virtual extern bool ShouldPlay(CardModel card, AutoPlayType autoPlayType);

	public virtual extern bool ShouldPlayerResetEnergy(Player player);

	public virtual extern bool ShouldProceedToNextMapPoint();

	public virtual extern bool ShouldProcurePotion(PotionModel potion, Player player);

	public virtual extern bool ShouldPowerBeRemovedOnDeath(PowerModel power);

	public virtual extern bool ShouldRefillMerchantEntry(MerchantEntry entry, Player player);

	public virtual extern bool ShouldAllowMerchantCardRemoval(Player player);

	public virtual extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	public virtual extern bool ShouldStopCombatFromEnding();

	public virtual extern bool ShouldTakeExtraTurn(Player player);

	public virtual extern bool ShouldForcePotionReward(Player player, RoomType roomType);

	public override extern string ToString();

	protected extern void NeverEverCallThisOutsideOfTests_SetIsMutable(bool isMutable);
}
