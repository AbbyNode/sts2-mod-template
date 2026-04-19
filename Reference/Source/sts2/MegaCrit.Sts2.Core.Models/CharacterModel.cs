using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.Achievements;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models;

public abstract class CharacterModel : AbstractModel
{
	public const string locTable = "characters";

	protected const string _relaxedTrigger = "Relaxed";

	protected const string _idleTrigger = "Idle";

	public const string relaxedAnim = "relaxed_loop";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString Title { get; }

	public extern LocString TitleObject { get; }

	public abstract Color NameColor { get; }

	public abstract CharacterGender Gender { get; }

	protected abstract CharacterModel? UnlocksAfterRunAs { get; }

	public extern LocString PronounObject { get; }

	public extern LocString PossessiveAdjective { get; }

	public extern LocString PronounPossessive { get; }

	public extern LocString PronounSubject { get; }

	public extern LocString CardsModifierTitle { get; }

	public extern LocString CardsModifierDescription { get; }

	public extern LocString EventDeathPreventionLine { get; }

	public extern string TrailPath { get; }

	public abstract int StartingHp { get; }

	public abstract int StartingGold { get; }

	public virtual extern int MaxEnergy { get; }

	public virtual extern Color EnergyLabelOutlineColor { get; }

	public virtual extern int BaseOrbSlotCount { get; }

	public virtual extern bool ShouldAlwaysShowStarCounter { get; }

	public abstract CardPoolModel CardPool { get; }

	public abstract RelicPoolModel RelicPool { get; }

	public abstract PotionPoolModel PotionPool { get; }

	public abstract IEnumerable<CardModel> StartingDeck { get; }

	public abstract IReadOnlyList<RelicModel> StartingRelics { get; }

	public virtual extern IReadOnlyList<PotionModel> StartingPotions { get; }

	public extern Texture2D IconTexture { get; }

	public extern Texture2D IconOutlineTexture { get; }

	public extern Control Icon { get; }

	public extern string EnergyCounterPath { get; }

	public extern string MerchantAnimPath { get; }

	public extern string RestSiteAnimPath { get; }

	public extern Texture2D ArmPointingTexture { get; }

	public extern Texture2D ArmRockTexture { get; }

	public extern Texture2D ArmPaperTexture { get; }

	public extern Texture2D ArmScissorsTexture { get; }

	public extern Achievement RunWonAchievement { get; }

	protected virtual extern IEnumerable<string> ExtraAssetPaths { get; }

	public extern string CharacterSelectTitle { get; }

	public extern string CharacterSelectDesc { get; }

	public extern string CharacterSelectBg { get; }

	protected virtual extern string CharacterSelectIconPath { get; }

	public extern CompressedTexture2D CharacterSelectIcon { get; }

	protected virtual extern string CharacterSelectLockedIconPath { get; }

	public extern CompressedTexture2D CharacterSelectLockedIcon { get; }

	public extern string CharacterSelectTransitionPath { get; }

	protected virtual extern string MapMarkerPath { get; }

	public extern CompressedTexture2D MapMarker { get; }

	public virtual extern Color DialogueColor
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern Color MapDrawingColor { get; }

	public virtual extern Color RemoteTargetingLineColor { get; }

	public virtual extern Color RemoteTargetingLineOutline { get; }

	public extern IEnumerable<string> AssetPathsCharacterSelect { get; }

	public extern IEnumerable<string> AssetPaths { get; }

	public abstract float AttackAnimDelay { get; }

	public abstract float CastAnimDelay { get; }

	public virtual extern string CharacterSelectSfx { get; }

	public extern string AttackSfx { get; }

	public extern string CastSfx { get; }

	public extern string DeathSfx { get; }

	public virtual extern string CharacterTransitionSfx { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern NCreatureVisuals CreateVisuals();

	public abstract List<string> GetArchitectAttackVfx();

	public virtual extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern void AddDetailsTo(LocString str);

	public extern LocString GetUnlockText();

	protected extern CharacterModel();
}
