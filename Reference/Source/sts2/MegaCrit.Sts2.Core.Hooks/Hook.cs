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
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Hooks;

public static class Hook
{
	[AsyncStateMachine(typeof(_003CAfterActEntered_003Ed__0))]
	public static extern Task AfterActEntered(IRunState runState);

	[AsyncStateMachine(typeof(_003CBeforeAttack_003Ed__1))]
	public static extern Task BeforeAttack(CombatState combatState, AttackCommand command);

	[AsyncStateMachine(typeof(_003CAfterAttack_003Ed__2))]
	public static extern Task AfterAttack(CombatState combatState, AttackCommand command);

	[AsyncStateMachine(typeof(_003CAfterBlockBroken_003Ed__3))]
	public static extern Task AfterBlockBroken(CombatState combatState, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterBlockCleared_003Ed__4))]
	public static extern Task AfterBlockCleared(CombatState combatState, Creature creature);

	[AsyncStateMachine(typeof(_003CBeforeBlockGained_003Ed__5))]
	public static extern Task BeforeBlockGained(CombatState combatState, Creature creature, decimal amount, ValueProp props, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterBlockGained_003Ed__6))]
	public static extern Task AfterBlockGained(CombatState combatState, Creature creature, decimal amount, ValueProp props, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CBeforeCardAutoPlayed_003Ed__7))]
	public static extern Task BeforeCardAutoPlayed(CombatState combatState, CardModel card, Creature? target, AutoPlayType type);

	[AsyncStateMachine(typeof(_003CAfterCardChangedPiles_003Ed__8))]
	public static extern Task AfterCardChangedPiles(IRunState runState, CombatState? combatState, CardModel card, PileType oldPile, AbstractModel? source);

	[AsyncStateMachine(typeof(_003CAfterCardDiscarded_003Ed__9))]
	public static extern Task AfterCardDiscarded(CombatState combatState, PlayerChoiceContext choiceContext, CardModel card);

	[AsyncStateMachine(typeof(_003CAfterCardDrawn_003Ed__10))]
	public static extern Task AfterCardDrawn(CombatState combatState, PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	[AsyncStateMachine(typeof(_003CAfterCardEnteredCombat_003Ed__11))]
	public static extern Task AfterCardEnteredCombat(CombatState combatState, CardModel card);

	[AsyncStateMachine(typeof(_003CAfterCardExhausted_003Ed__12))]
	public static extern Task AfterCardExhausted(CombatState combatState, PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal);

	[AsyncStateMachine(typeof(_003CAfterCardGeneratedForCombat_003Ed__13))]
	public static extern Task AfterCardGeneratedForCombat(CombatState combatState, CardModel card, bool addedByPlayer);

	[AsyncStateMachine(typeof(_003CBeforeCardPlayed_003Ed__14))]
	public static extern Task BeforeCardPlayed(CombatState combatState, CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__15))]
	public static extern Task AfterCardPlayed(CombatState combatState, PlayerChoiceContext choiceContext, CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CBeforeCardRemoved_003Ed__16))]
	public static extern Task BeforeCardRemoved(IRunState runState, CardModel card);

	[AsyncStateMachine(typeof(_003CAfterCardRetained_003Ed__17))]
	public static extern Task AfterCardRetained(CombatState combatState, CardModel card);

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__18))]
	public static extern Task BeforeCombatStart(IRunState runState, CombatState? combatState);

	[AsyncStateMachine(typeof(_003CAfterCombatEnd_003Ed__19))]
	public static extern Task AfterCombatEnd(IRunState runState, CombatState? combatState, CombatRoom room);

	[AsyncStateMachine(typeof(_003CAfterCombatVictory_003Ed__20))]
	public static extern Task AfterCombatVictory(IRunState runState, CombatState? combatState, CombatRoom room);

	[AsyncStateMachine(typeof(_003CAfterCreatureAddedToCombat_003Ed__21))]
	public static extern Task AfterCreatureAddedToCombat(CombatState combatState, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterCurrentHpChanged_003Ed__22))]
	public static extern Task AfterCurrentHpChanged(IRunState runState, CombatState? combatState, Creature creature, decimal delta);

	[AsyncStateMachine(typeof(_003CAfterDamageGiven_003Ed__23))]
	public static extern Task AfterDamageGiven(PlayerChoiceContext choiceContext, CombatState combatState, Creature? dealer, DamageResult results, ValueProp props, Creature target, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CBeforeDamageReceived_003Ed__24))]
	public static extern Task BeforeDamageReceived(PlayerChoiceContext choiceContext, IRunState runState, CombatState? combatState, Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterDamageReceived_003Ed__25))]
	public static extern Task AfterDamageReceived(PlayerChoiceContext choiceContext, IRunState runState, CombatState? combatState, Creature target, DamageResult result, ValueProp props, Creature? dealer, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CBeforeDeath_003Ed__26))]
	public static extern Task BeforeDeath(IRunState runState, CombatState? combatState, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__27))]
	public static extern Task AfterDeath(IRunState runState, CombatState? combatState, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	[AsyncStateMachine(typeof(_003CAfterGoldGained_003Ed__28))]
	public static extern Task AfterGoldGained(IRunState runState, Player player);

	[AsyncStateMachine(typeof(_003CAfterDiedToDoom_003Ed__29))]
	public static extern Task AfterDiedToDoom(CombatState combatState, IReadOnlyList<Creature> creatures);

	[AsyncStateMachine(typeof(_003CAfterEnergyReset_003Ed__30))]
	public static extern Task AfterEnergyReset(CombatState combatState, Player player);

	[AsyncStateMachine(typeof(_003CAfterEnergySpent_003Ed__31))]
	public static extern Task AfterEnergySpent(CombatState combatState, CardModel card, int amount);

	[AsyncStateMachine(typeof(_003CBeforeFlush_003Ed__32))]
	public static extern Task BeforeFlush(CombatState combatState, Player player);

	[AsyncStateMachine(typeof(_003CAfterForge_003Ed__33))]
	public static extern Task AfterForge(CombatState combatState, decimal amount, Player forger, AbstractModel? source);

	[AsyncStateMachine(typeof(_003CBeforeHandDraw_003Ed__34))]
	public static extern Task BeforeHandDraw(CombatState combatState, Player player, PlayerChoiceContext playerChoiceContext);

	[AsyncStateMachine(typeof(_003CAfterHandEmptied_003Ed__35))]
	public static extern Task AfterHandEmptied(CombatState combatState, PlayerChoiceContext choiceContext, Player player);

	[AsyncStateMachine(typeof(_003CAfterItemPurchased_003Ed__36))]
	public static extern Task AfterItemPurchased(IRunState runState, Player player, MerchantEntry itemPurchased, int goldSpent);

	[AsyncStateMachine(typeof(_003CAfterMapGenerated_003Ed__37))]
	public static extern Task AfterMapGenerated(IRunState runState, ActMap map, int actIndex);

	[AsyncStateMachine(typeof(_003CAfterModifyingBlockAmount_003Ed__38))]
	public static extern Task AfterModifyingBlockAmount(CombatState combatState, decimal modifiedBlock, CardModel? cardSource, CardPlay? cardPlay, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingCardPlayCount_003Ed__39))]
	public static extern Task AfterModifyingCardPlayCount(CombatState combatState, CardModel card, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingCardRewardOptions_003Ed__40))]
	public static extern Task AfterModifyingCardRewardOptions(IRunState runState, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingDamageAmount_003Ed__41))]
	public static extern Task AfterModifyingDamageAmount(IRunState runState, CombatState? combatState, CardModel? cardSource, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingHandDraw_003Ed__42))]
	public static extern Task AfterModifyingHandDraw(CombatState combatState, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingHpLostBeforeOsty_003Ed__43))]
	public static extern Task AfterModifyingHpLostBeforeOsty(IRunState runState, CombatState? combatState, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingHpLostAfterOsty_003Ed__44))]
	public static extern Task AfterModifyingHpLostAfterOsty(IRunState runState, CombatState? combatState, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingOrbPassiveTriggerCount_003Ed__45))]
	public static extern Task AfterModifyingOrbPassiveTriggerCount(CombatState combatState, OrbModel orb, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterModifyingPowerAmountGiven_003Ed__46))]
	public static extern Task AfterModifyingPowerAmountGiven(CombatState combatState, IEnumerable<AbstractModel> modifiers, PowerModel modifiedPower);

	[AsyncStateMachine(typeof(_003CAfterModifyingPowerAmountReceived_003Ed__47))]
	public static extern Task AfterModifyingPowerAmountReceived(CombatState combatState, IEnumerable<AbstractModel> modifiers, PowerModel modifiedPower);

	[AsyncStateMachine(typeof(_003CAfterModifyingRewards_003Ed__48))]
	public static extern Task AfterModifyingRewards(IRunState runState, IEnumerable<AbstractModel> modifiers);

	[AsyncStateMachine(typeof(_003CAfterOrbChanneled_003Ed__49))]
	public static extern Task AfterOrbChanneled(CombatState combatState, PlayerChoiceContext choiceContext, Player player, OrbModel orb);

	[AsyncStateMachine(typeof(_003CAfterOrbEvoked_003Ed__50))]
	public static extern Task AfterOrbEvoked(PlayerChoiceContext choiceContext, CombatState combatState, OrbModel orb, IEnumerable<Creature> targets);

	[AsyncStateMachine(typeof(_003CAfterOstyRevived_003Ed__51))]
	public static extern Task AfterOstyRevived(CombatState combatState, Creature osty);

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStart_003Ed__52))]
	public static extern Task AfterPlayerTurnStart(CombatState combatState, PlayerChoiceContext choiceContext, Player player);

	[AsyncStateMachine(typeof(_003CBeforePlayPhaseStart_003Ed__53))]
	public static extern Task BeforePlayPhaseStart(CombatState combatState, Player player);

	[AsyncStateMachine(typeof(_003CAfterPotionDiscarded_003Ed__54))]
	public static extern Task AfterPotionDiscarded(IRunState runState, CombatState? combatState, PotionModel potion);

	[AsyncStateMachine(typeof(_003CAfterPotionProcured_003Ed__55))]
	public static extern Task AfterPotionProcured(IRunState runState, CombatState? combatState, PotionModel potion);

	[AsyncStateMachine(typeof(_003CBeforePotionUsed_003Ed__56))]
	public static extern Task BeforePotionUsed(IRunState runState, CombatState? combatState, PotionModel potion, Creature? target);

	[AsyncStateMachine(typeof(_003CAfterPotionUsed_003Ed__57))]
	public static extern Task AfterPotionUsed(IRunState runState, CombatState? combatState, PotionModel potion, Creature? target);

	[AsyncStateMachine(typeof(_003CBeforePowerAmountChanged_003Ed__58))]
	public static extern Task BeforePowerAmountChanged(CombatState combatState, PowerModel power, decimal amount, Creature target, Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterPowerAmountChanged_003Ed__59))]
	public static extern Task AfterPowerAmountChanged(CombatState combatState, PowerModel power, decimal amount, Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterPreventingBlockClear_003Ed__60))]
	public static extern Task AfterPreventingBlockClear(CombatState combatState, AbstractModel preventer, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingDeath_003Ed__61))]
	public static extern Task AfterPreventingDeath(IRunState runState, CombatState? combatState, AbstractModel preventer, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingDraw_003Ed__62))]
	public static extern Task AfterPreventingDraw(CombatState combatState, AbstractModel modifier);

	[AsyncStateMachine(typeof(_003CAfterRestSiteHeal_003Ed__63))]
	public static extern Task AfterRestSiteHeal(IRunState runState, Player player, bool isMimicked);

	[AsyncStateMachine(typeof(_003CAfterRestSiteSmith_003Ed__64))]
	public static extern Task AfterRestSiteSmith(IRunState runState, Player player);

	[AsyncStateMachine(typeof(_003CBeforeRewardsOffered_003Ed__65))]
	public static extern Task BeforeRewardsOffered(IRunState runState, Player player, IReadOnlyList<Reward> rewards);

	[AsyncStateMachine(typeof(_003CAfterRewardTaken_003Ed__66))]
	public static extern Task AfterRewardTaken(IRunState runState, Player player, Reward reward);

	[AsyncStateMachine(typeof(_003CBeforeRoomEntered_003Ed__67))]
	public static extern Task BeforeRoomEntered(IRunState runState, AbstractRoom room);

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__68))]
	public static extern Task AfterRoomEntered(IRunState runState, AbstractRoom room);

	[AsyncStateMachine(typeof(_003CAfterShuffle_003Ed__69))]
	public static extern Task AfterShuffle(CombatState combatState, PlayerChoiceContext choiceContext, Player shuffler);

	[AsyncStateMachine(typeof(_003CBeforeSideTurnStart_003Ed__70))]
	public static extern Task BeforeSideTurnStart(CombatState combatState, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__71))]
	public static extern Task AfterSideTurnStart(CombatState combatState, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterStarsGained_003Ed__72))]
	public static extern Task AfterStarsGained(CombatState combatState, int amount, Player gainer);

	[AsyncStateMachine(typeof(_003CAfterStarsSpent_003Ed__73))]
	public static extern Task AfterStarsSpent(CombatState combatState, int amount, Player spender);

	[AsyncStateMachine(typeof(_003CAfterSummon_003Ed__74))]
	public static extern Task AfterSummon(CombatState combatState, PlayerChoiceContext choiceContext, Player summoner, decimal amount);

	[AsyncStateMachine(typeof(_003CAfterTakingExtraTurn_003Ed__75))]
	public static extern Task AfterTakingExtraTurn(CombatState combatState, Player player);

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__76))]
	public static extern Task BeforeTurnEnd(CombatState combatState, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__77))]
	public static extern Task AfterTurnEnd(CombatState combatState, CombatSide side);

	public static extern decimal ModifyAttackHitCount(CombatState combatState, AttackCommand attackCommand, int originalHitCount);

	public static extern decimal ModifyBlock(CombatState combatState, Creature target, decimal block, ValueProp props, CardModel? cardSource, CardPlay? cardPlay, out IEnumerable<AbstractModel> modifiers);

	public static extern CardModel ModifyCardBeingAddedToDeck(IRunState runState, CardModel card, out List<AbstractModel> modifyingModels);

	public static extern int ModifyCardPlayCount(CombatState combatState, CardModel card, int playCount, Creature? target, out List<AbstractModel> modifyingModels);

	public static extern (PileType, CardPilePosition) ModifyCardPlayResultPileTypeAndPosition(CombatState combatState, CardModel card, bool isAutoPlay, ResourceInfo resources, PileType pileType, CardPilePosition position, out IEnumerable<AbstractModel> modifiers);

	public static extern IEnumerable<AbstractModel> ModifyCardRewardAlternatives(IRunState runState, Player player, CardReward cardReward, List<CardRewardAlternative> alternatives);

	public static extern CardCreationOptions ModifyCardRewardCreationOptions(IRunState runState, Player player, CardCreationOptions options);

	public static extern bool TryModifyCardRewardOptions(IRunState runState, Player player, List<CardCreationResult> cardRewardOptions, CardCreationOptions creationOptions, out List<AbstractModel> modifiers);

	public static extern decimal ModifyCardRewardUpgradeOdds(IRunState runState, Player player, CardModel card, decimal originalOdds);

	public static extern decimal ModifyDamage(IRunState runState, CombatState? combatState, Creature? target, Creature? dealer, decimal damage, ValueProp props, CardModel? cardSource, ModifyDamageHookType modifyDamageHookType, CardPreviewMode previewMode, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyEnergyCostInCombat(CombatState combatState, CardModel card, decimal originalCost);

	public static extern IReadOnlyList<LocString> ModifyExtraRestSiteHealText(IRunState runState, Player player, IReadOnlyList<LocString> extraText);

	public static extern ActMap ModifyGeneratedMap(IRunState runState, ActMap map, int actIndex);

	public static extern ActMap ModifyGeneratedMapLate(IRunState runState, ActMap map, int actIndex);

	public static extern decimal ModifyHandDraw(CombatState combatState, Player player, decimal originalCardCount, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyHealAmount(IRunState runState, CombatState? combatState, Creature creature, decimal amount);

	public static extern decimal ModifyHpLostBeforeOsty(IRunState runState, CombatState? combatState, Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyHpLostAfterOsty(IRunState runState, CombatState? combatState, Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyMaxEnergy(CombatState combatState, Player player, decimal amount);

	public static extern void ModifyMerchantCardCreationResults(IRunState runState, Player player, List<CardCreationResult> cards);

	public static extern IEnumerable<CardModel> ModifyMerchantCardPool(IRunState runState, Player player, IEnumerable<CardModel> options);

	public static extern CardRarity ModifyMerchantCardRarity(IRunState runState, Player player, CardRarity rarity);

	public static extern decimal ModifyMerchantPrice(IRunState runState, Player player, MerchantEntry entry, decimal result);

	public static extern EventModel ModifyNextEvent(IRunState runState, EventModel currentEvent);

	public static extern float ModifyOddsIncreaseForUnrolledRoomType(IRunState runState, RoomType roomType, float oddsIncrease);

	public static extern int ModifyOrbPassiveTriggerCount(CombatState combatState, OrbModel orb, int triggerCount, out List<AbstractModel> modifyingModels);

	public static extern decimal ModifyOrbValue(CombatState combatState, Player player, decimal amount);

	public static extern decimal ModifyPowerAmountGiven(CombatState combatState, PowerModel power, Creature giver, decimal amount, Creature? target, CardModel? cardSource, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyPowerAmountReceived(CombatState combatState, PowerModel canonicalPower, Creature target, decimal amount, Creature? giver, out IEnumerable<AbstractModel> modifiers);

	public static extern decimal ModifyRestSiteHealAmount(IRunState runState, Creature creature, decimal amount);

	public static extern IEnumerable<AbstractModel> ModifyRestSiteOptions(IRunState runState, Player player, ICollection<RestSiteOption> options);

	public static extern IEnumerable<AbstractModel> ModifyRestSiteHealRewards(IRunState runState, Player player, List<Reward> rewards, bool isMimicked);

	public static extern IEnumerable<AbstractModel> ModifyRewards(IRunState runState, Player player, List<Reward> rewards, AbstractRoom? room);

	public static extern void ModifyShuffleOrder(CombatState combatState, Player player, List<CardModel> cards, bool isInitialShuffle);

	public static extern decimal ModifyStarCost(CombatState combatState, CardModel card, decimal originalCost);

	public static extern decimal ModifySummonAmount(CombatState combatState, Player summoner, decimal amount, AbstractModel? source);

	public static extern Creature ModifyUnblockedDamageTarget(CombatState combatState, Creature originalTarget, decimal amount, ValueProp props, Creature? dealer);

	public static extern IReadOnlySet<RoomType> ModifyUnknownMapPointRoomTypes(IRunState runState, IReadOnlySet<RoomType> roomTypes);

	public static extern int ModifyXValue(CombatState combatState, CardModel card, int originalValue);

	public static extern bool ShouldAddToDeck(IRunState runState, CardModel card, out AbstractModel? preventer);

	public static extern bool ShouldAfflict(CombatState combatState, CardModel card, AfflictionModel affliction);

	public static extern bool ShouldAllowAncient(IRunState runState, Player player, AncientEventModel ancient);

	public static extern bool ShouldAllowHitting(CombatState combatState, Creature creature);

	public static extern bool ShouldAllowMerchantCardRemoval(IRunState runState, Player player);

	public static extern bool ShouldAllowSelectingMoreCardRewards(IRunState runState, Player player, CardReward reward);

	public static extern bool ShouldAllowTargeting(CombatState combatState, Creature target, out AbstractModel? preventer);

	public static extern bool ShouldClearBlock(CombatState combatState, Creature creature, out AbstractModel? preventer);

	public static extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(CombatState combatState, Creature creature);

	public static extern bool ShouldDie(IRunState runState, CombatState? combatState, Creature creature, out AbstractModel? preventer);

	public static extern bool ShouldDisableRemainingRestSiteOptions(IRunState runState, Player player);

	public static extern bool ShouldDraw(CombatState combatState, Player player, bool fromHandDraw, out AbstractModel? modifier);

	public static extern bool ShouldEtherealTrigger(CombatState combatState, CardModel card);

	public static extern bool ShouldFlush(CombatState combatState, Player player);

	public static extern bool ShouldGainGold(IRunState runState, CombatState? combatState, decimal amount, Player player);

	public static extern bool ShouldGenerateTreasure(IRunState runState, Player player);

	public static extern bool ShouldGainStars(CombatState combatState, decimal amount, Player player);

	public static extern bool ShouldPayExcessEnergyCostWithStars(CombatState combatState, Player player);

	public static extern bool ShouldPlay(CombatState combatState, CardModel card, out AbstractModel? preventer, AutoPlayType autoPlayType);

	public static extern bool ShouldPlayerResetEnergy(CombatState combatState, Player player);

	public static extern bool ShouldProceedToNextMapPoint(IRunState runState);

	public static extern bool ShouldProcurePotion(IRunState runState, CombatState? combatState, PotionModel potion, Player player);

	public static extern bool ShouldRefillMerchantEntry(IRunState runState, MerchantEntry entry, Player player);

	public static extern bool ShouldStopCombatFromEnding(CombatState combatState);

	public static extern bool ShouldTakeExtraTurn(CombatState combatState, Player player);

	public static extern bool ShouldForcePotionReward(IRunState runState, Player player, RoomType roomType);

	public static extern bool ShouldPowerBeRemovedOnDeath(PowerModel power);
}
