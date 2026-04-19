using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.UI;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Pooling;

namespace MegaCrit.Sts2.Core.Nodes.Cards;

[ScriptPath("res://src/Core/Nodes/Cards/NCard.cs")]
public class NCard : Control, IPoolable
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName OnInstantiated;

		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName InitPool;

		public static readonly StringName GetCurrentSize;

		public static readonly StringName UpdateVisuals;

		public static readonly StringName ShowUpgradePreview;

		public static readonly StringName UpdateEnchantmentVisuals;

		public static readonly StringName OnEnchantmentStatusChanged;

		public static readonly StringName SetEnchantmentStatus;

		public static readonly StringName UpdateEnergyCostVisuals;

		public static readonly StringName SetPretendCardCanBePlayed;

		public static readonly StringName SetForceUnpoweredPreview;

		public static readonly StringName UpdateEnergyCostColor;

		public static readonly StringName UpdateStarCostVisuals;

		public static readonly StringName UpdateStarCostText;

		public static readonly StringName UpdateStarCostColor;

		public static readonly StringName GetCostTextColorInHand;

		public static readonly StringName GetCostOutlineColorInHand;

		public static readonly StringName PlayRandomizeCostAnim;

		public static readonly StringName Reload;

		public static readonly StringName UpdateTypePlaque;

		public static readonly StringName UpdateTypePlaqueSizeAndPosition;

		public static readonly StringName UpdateTitleLabel;

		public static readonly StringName GetTitleLabelOutlineColor;

		public static readonly StringName ReloadOverlay;

		public static readonly StringName OnAfflictionChanged;

		public static readonly StringName OnEnchantmentChanged;

		public static readonly StringName GetTitleText;

		public static readonly StringName ActivateRewardScreenGlow;

		public static readonly StringName KillRarityGlow;

		public static readonly StringName AnimCardToPlayPile;

		public static readonly StringName OnReturnedFromPool;

		public static readonly StringName OnFreedToPool;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CardHighlight;

		public static readonly StringName Body;

		public static readonly StringName Visibility;

		public static readonly StringName PlayPileTween;

		public static readonly StringName RandomizeCostTween;

		public static readonly StringName DisplayingPile;

		public static readonly StringName EnchantmentTab;

		public static readonly StringName EnchantmentVfxOverride;

		public static readonly StringName _titleLabel;

		public static readonly StringName _descriptionLabel;

		public static readonly StringName _ancientPortrait;

		public static readonly StringName _portrait;

		public static readonly StringName _frame;

		public static readonly StringName _ancientBorder;

		public static readonly StringName _ancientBanner;

		public static readonly StringName _ancientTextBg;

		public static readonly StringName _ancientHighlight;

		public static readonly StringName _portraitBorder;

		public static readonly StringName _banner;

		public static readonly StringName _lock;

		public static readonly StringName _typePlaque;

		public static readonly StringName _typeLabel;

		public static readonly StringName _portraitCanvasGroup;

		public static readonly StringName _rareGlow;

		public static readonly StringName _uncommonGlow;

		public static readonly StringName _sparkles;

		public static readonly StringName _energyIcon;

		public static readonly StringName _energyLabel;

		public static readonly StringName _unplayableEnergyIcon;

		public static readonly StringName _starIcon;

		public static readonly StringName _starLabel;

		public static readonly StringName _unplayableStarIcon;

		public static readonly StringName _overlayContainer;

		public static readonly StringName _cardOverlay;

		public static readonly StringName _enchantmentTab;

		public static readonly StringName _enchantmentVfxOverride;

		public static readonly StringName _enchantmentIcon;

		public static readonly StringName _enchantmentLabel;

		public static readonly StringName _defaultEnchantmentPosition;

		public static readonly StringName _pretendCardCanBePlayed;

		public static readonly StringName _forceUnpoweredPreview;

		public static readonly StringName _portraitBlurMaterial;

		public static readonly StringName _canvasGroupMaskBlurMaterial;

		public static readonly StringName _canvasGroupBlurMaterial;

		public static readonly StringName _canvasGroupMaskMaterial;

		public static readonly StringName _visibility;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public static readonly Vector2 defaultSize;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NCardHighlight CardHighlight
	{
		[CompilerGenerated]
		get;
	}

	public extern Control Body
	{
		[CompilerGenerated]
		get;
	}

	public extern ModelVisibility Visibility { get; set; }

	public extern Tween? PlayPileTween
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern PileType DisplayingPile
	{
		[CompilerGenerated]
		get;
	}

	public extern Control EnchantmentTab { get; }

	public extern TextureRect EnchantmentVfxOverride { get; }

	public extern CardModel? Model { get; set; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern event Action<CardModel?>? ModelChanged;

	public extern void OnInstantiated();

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public static extern void InitPool();

	public static extern NCard? Create(CardModel card, ModelVisibility visibility = ModelVisibility.Visible);

	public static extern NCard? FindOnTable(CardModel card, PileType? overridePile = null);

	public extern Vector2 GetCurrentSize();

	public extern void SetPreviewTarget(Creature? creature);

	public extern void UpdateVisuals(PileType pileType, CardPreviewMode previewMode);

	public extern void ShowUpgradePreview();

	public extern void SetPretendCardCanBePlayed(bool pretendCardCanBePlayed);

	public extern void SetForceUnpoweredPreview(bool forceUnpoweredPreview);

	public extern void PlayRandomizeCostAnim();

	public extern void ActivateRewardScreenGlow();

	public extern void FlashRelicOnCard(RelicModel relic);

	public extern void KillRarityGlow();

	[AsyncStateMachine(typeof(_003CAnimMultiCardPlay_003Ed__133))]
	public extern Task AnimMultiCardPlay();

	public extern void AnimCardToPlayPile();

	public extern void OnReturnedFromPool();

	public extern void OnFreedToPool();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NCard();
}
