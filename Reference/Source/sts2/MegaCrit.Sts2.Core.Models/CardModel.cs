using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class CardModel : AbstractModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString TitleLocString { get; }

	public extern string Title { get; }

	public extern LocString Description { get; }

	protected extern LocString SelectionScreenPrompt { get; }

	public virtual extern string PortraitPath { get; }

	public virtual extern string BetaPortraitPath { get; }

	public static extern string MissingPortraitPath { get; }

	public extern bool HasPortrait { get; }

	public extern bool HasBetaPortrait { get; }

	public extern Texture2D Portrait { get; }

	public extern Texture2D Frame { get; }

	public extern Texture2D AncientTextBg { get; }

	public extern Texture2D PortraitBorder { get; }

	public extern Texture2D EnergyIcon { get; }

	protected extern IHoverTip EnergyHoverTip { get; }

	public extern Texture2D BannerTexture { get; }

	public extern Material BannerMaterial { get; }

	public extern Material FrameMaterial { get; }

	public virtual extern CardType Type
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern CardRarity Rarity
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern CardMultiplayerConstraint MultiplayerConstraint { get; }

	public virtual extern CardPoolModel Pool { get; }

	public virtual extern CardPoolModel VisualCardPool { get; }

	public extern Player Owner { get; set; }

	public extern CardPile? Pile { get; }

	protected virtual extern int CanonicalEnergyCost
	{
		[CompilerGenerated]
		get;
	}

	protected virtual extern bool HasEnergyCostX { get; }

	public extern CardEnergyCost EnergyCost { get; }

	public extern int BaseReplayCount { get; set; }

	public virtual extern int CanonicalStarCost { get; }

	public extern int BaseStarCost { get; }

	public extern bool WasStarCostJustUpgraded { get; }

	public extern TemporaryCardCost? TemporaryStarCost { get; }

	public virtual extern int CurrentStarCost { get; }

	public virtual extern bool HasStarCostX { get; }

	public extern int LastStarsSpent { get; set; }

	public virtual extern TargetType TargetType
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern IReadOnlySet<CardKeyword> Keywords { get; }

	public virtual extern IEnumerable<CardTag> Tags { get; }

	protected virtual extern HashSet<CardTag> CanonicalTags { get; }

	public extern DynamicVarSet DynamicVars { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern bool ExhaustOnNextPlay { get; set; }

	public extern bool ShouldRetainThisTurn { get; }

	public extern bool IsSlyThisTurn { get; }

	public extern EnchantmentModel? Enchantment
	{
		[CompilerGenerated]
		get;
	}

	public extern AfflictionModel? Affliction
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern bool CanBeGeneratedInCombat { get; }

	public virtual extern bool CanBeGeneratedByModifiers { get; }

	public virtual extern OrbEvokeType OrbEvokeType { get; }

	public virtual extern bool GainsBlock { get; }

	public virtual extern bool IsBasicStrikeOrDefend { get; }

	public extern CardModel? CloneOf { get; }

	public extern bool IsClone { get; }

	public extern CardModel? DupeOf { get; }

	public extern bool IsDupe { get; }

	public extern bool IsRemovable { get; }

	public extern bool IsTransformable { get; }

	public extern bool IsInCombat { get; }

	public extern int CurrentUpgradeLevel { get; }

	public virtual extern int MaxUpgradeLevel { get; }

	public extern bool IsUpgraded { get; }

	public extern bool IsUpgradable { get; }

	public extern CardUpgradePreviewType UpgradePreviewType { get; set; }

	protected virtual extern bool IsPlayable { get; }

	public extern bool ShouldShowInCardLibrary
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldGlowGold { get; }

	public extern bool ShouldGlowRed { get; }

	protected virtual extern bool ShouldGlowGoldInternal { get; }

	protected virtual extern bool ShouldGlowRedInternal { get; }

	public extern bool IsEnchantmentPreview { get; set; }

	public virtual extern bool HasBuiltInOverlay { get; }

	public extern string OverlayPath { get; }

	public extern int? FloorAddedToDeck { get; set; }

	public extern Creature? CurrentTarget { get; }

	public extern CardModel? DeckVersion { get; set; }

	public extern bool HasBeenRemovedFromState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern CardModel CanonicalInstance { get; }

	public extern IRunState? RunState { get; }

	public extern CombatState? CombatState { get; }

	public extern ICardScope? CardScope { get; }

	public virtual extern bool HasTurnEndInHandEffect { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern IEnumerable<string> AllPortraitPaths { get; }

	public extern IEnumerable<string> RunAssetPaths { get; }

	protected virtual extern IEnumerable<string> ExtraRunAssetPaths { get; }

	public extern event Action? AfflictionChanged;

	public extern event Action? EnchantmentChanged;

	public extern event Action? EnergyCostChanged;

	public extern event Action? KeywordsChanged;

	public extern event Action? ReplayCountChanged;

	public extern event Action? Played;

	public extern event Action? Drawn;

	public extern event Action? StarCostChanged;

	public extern event Action? Upgraded;

	public extern event Action? Forged;

	protected extern CardModel(int canonicalEnergyCost, CardType type, CardRarity rarity, TargetType targetType, bool shouldShowInCardLibrary = true);

	protected extern void MockSetEnergyCost(CardEnergyCost cost);

	public extern void InvokeEnergyCostChanged();

	public extern int ResolveEnergyXValue();

	public extern int GetEnchantedReplayCount();

	public extern int ResolveStarXValue();

	public extern Control CreateOverlay();

	public extern CardModel ToMutable();

	protected override extern void DeepCloneFields();

	protected override extern void AfterCloned();

	public virtual extern void AfterCreated();

	protected virtual extern void AfterDeserialized();

	protected extern void NeverEverCallThisOutsideOfTests_ClearOwner();

	public extern void SetToFreeThisTurn();

	public extern void SetToFreeThisCombat();

	public extern void SetStarCostUntilPlayed(int cost);

	public extern void SetStarCostThisTurn(int cost);

	public extern void SetStarCostThisCombat(int cost);

	public extern int GetStarCostThisCombat();

	protected extern void UpgradeStarCostBy(int addend);

	public extern void AddKeyword(CardKeyword keyword);

	public extern void RemoveKeyword(CardKeyword keyword);

	public extern void GiveSingleTurnRetain();

	public extern void GiveSingleTurnSly();

	public extern string GetDescriptionForPile(PileType pileType, Creature? target = null);

	public extern string GetDescriptionForUpgradePreview();

	public extern void UpdateDynamicVarPreview(CardPreviewMode previewMode, Creature? target, DynamicVarSet dynamicVarSet);

	public extern void EnchantInternal(EnchantmentModel enchantment, decimal amount);

	public extern void AfflictInternal(AfflictionModel affliction, decimal amount);

	public extern void ClearEnchantmentInternal();

	public extern void ClearAfflictionInternal();

	protected virtual extern void AddExtraArgsToDescription(LocString description);

	public extern int GetStarCostWithModifiers();

	public extern bool CostsEnergyOrStars(bool includeGlobalModifiers);

	public extern void RemoveFromCurrentPile();

	public extern void RemoveFromState();

	public extern void EndOfTurnCleanup();

	public virtual extern void AfterTransformedFrom();

	public virtual extern void AfterTransformedTo();

	public extern void AfterForged();

	protected virtual extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay cardPlay);

	public virtual extern Task OnEnqueuePlayVfx(Creature? target);

	protected virtual extern void OnUpgrade();

	public virtual extern Task OnTurnEndInHand(PlayerChoiceContext choiceContext);

	public extern bool CanPlayTargeting(Creature? target);

	public extern bool CanPlay();

	public extern bool CanPlay(out UnplayableReason reason, out AbstractModel? preventer);

	public extern bool IsValidTarget(Creature? target);

	public extern bool TryManualPlay(Creature? target);

	[AsyncStateMachine(typeof(_003CSpendResources_003Ed__324))]
	public extern Task<(int, int)> SpendResources();

	[AsyncStateMachine(typeof(_003COnPlayWrapper_003Ed__327))]
	public extern Task OnPlayWrapper(PlayerChoiceContext choiceContext, Creature? target, bool isAutoPlay, ResourceInfo resources, bool skipCardPileVisuals = false);

	protected virtual extern PileType GetResultPileType();

	[AsyncStateMachine(typeof(_003CMoveToResultPileWithoutPlaying_003Ed__330))]
	public extern Task MoveToResultPileWithoutPlaying(PlayerChoiceContext choiceContext);

	public extern void UpgradeInternal();

	public extern void FinalizeUpgradeInternal();

	public extern void DowngradeInternal();

	protected virtual extern void AfterDowngraded();

	public extern void InvokeDrawn();

	public extern CardModel CreateClone();

	public extern CardModel CreateDupe();

	public extern SerializableCard ToSerializable();

	public static extern CardModel FromSerializable(SerializableCard save);

	public override extern int CompareTo(AbstractModel? other);
}
