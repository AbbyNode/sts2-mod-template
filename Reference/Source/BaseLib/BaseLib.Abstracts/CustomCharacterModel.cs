using System;
using System.Collections.Generic;
using BaseLib.Extensions;
using BaseLib.Patches.UI;
using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.RestSite;
using MegaCrit.Sts2.Core.Nodes.Screens.Shops;

namespace BaseLib.Abstracts;

public abstract class CustomCharacterModel : CharacterModel, ICustomModel, ILocalizationProvider, ISceneConversions
{
	/// <summary>
	/// Override this to define localization directly in your class.
	/// You are recommended to return a CharacterLoc<seealso cref="T:BaseLib.Abstracts.CharacterLoc" />.
	/// </summary>
	public virtual List<(string, string)>? Localization => null;

	/// <summary>
	/// Override and return true if this character should be omitted from the vanilla character select screen.
	/// The character remains registered in ModelDb for other systems and custom UIs.
	/// </summary>
	public virtual bool HideFromVanillaCharacterSelect => false;

	/// <summary>
	/// Override and return true if this character should be eligible for the vanilla random character button.
	/// Defaults to the inverse of <seealso cref="P:BaseLib.Abstracts.CustomCharacterModel.HideFromVanillaCharacterSelect" />.
	/// </summary>
	public virtual bool AllowInVanillaRandomCharacterSelect => !HideFromVanillaCharacterSelect;

	/// <summary>
	/// Override this or place your scene at res://scenes/creature_visuals/class_name.tscn
	/// </summary>
	public virtual string? CustomVisualPath => null;

	public virtual string? CustomTrailPath => null;

	public virtual string? CustomIconTexturePath => null;

	public virtual string? CustomIconOutlineTexturePath => null;

	/// <summary>
	/// Path to a scene for top left in-run icon, stats screen, daily run icon, and run history icon.
	/// </summary>
	public virtual string? CustomIconPath => null;

	/// <summary>
	/// Generate icon for top left in-run icon, stats screen, daily run icon, and run history icon.
	/// Takes precedence over CustomIconPath.
	/// </summary>
	public virtual Control? CustomIcon => null;

	/// <summary>
	/// Legacy simple energy counter API. Prefer <seealso cref="P:BaseLib.Abstracts.CustomCharacterModel.CustomEnergyCounterPath" />CustomEnergyCounterPath.
	/// </summary>
	public virtual CustomEnergyCounter? CustomEnergyCounter => null;

	/// <summary>
	/// A pure Godot scene that BaseLib will convert into a usable NEnergyCounter at runtime.
	/// Standard Godot nodes such as Control, Label, TextureRect, Node2D, and GpuParticles2D will be converted as necessary.
	/// </summary>
	public virtual string? CustomEnergyCounterPath => null;

	/// <summary>
	/// Path to a Godot scene for the rest site animation.
	/// It can either be fully set up as a rest site animation scene, or a single root Sprite2D node which will be automatically converted.
	/// </summary>
	public virtual string? CustomRestSiteAnimPath => null;

	public virtual string? CustomMerchantAnimPath => null;

	public virtual string? CustomArmPointingTexturePath => null;

	public virtual string? CustomArmRockTexturePath => null;

	public virtual string? CustomArmPaperTexturePath => null;

	public virtual string? CustomArmScissorsTexturePath => null;

	public virtual RelicIconData? CustomYummyCookie => null;

	/// <summary>
	/// Override this or place your scene at res://scenes/screens/char_select/char_select_bg_class_name.tscn
	/// </summary>
	public virtual string? CustomCharacterSelectBg => null;

	public virtual string? CustomCharacterSelectIconPath => null;

	public virtual string? CustomCharacterSelectLockedIconPath => null;

	public virtual string? CustomCharacterSelectTransitionPath => null;

	public virtual string? CustomMapMarkerPath => null;

	public virtual string? CustomAttackSfx => null;

	public virtual string? CustomCastSfx => null;

	public virtual string? CustomDeathSfx => null;

	public override int StartingGold => 99;

	public override float AttackAnimDelay => 0.15f;

	public override float CastAnimDelay => 0.25f;

	protected override CharacterModel? UnlocksAfterRunAs => null;

	public CustomCharacterModel()
	{
		ModelDbCustomCharacters.Register(this);
	}

	/// <summary>
	/// Override to provide a custom NCreatureVisuals scene.
	/// If not overridden, an NCreatureVisuals will be generated from CustomVisualPath.
	/// </summary>
	/// <returns></returns>
	public virtual NCreatureVisuals? CreateCustomVisuals()
	{
		return null;
	}

	/// <summary>
	/// Override and return a CreatureAnimator if you need to set up states that differ from the default for your character.
	/// Using SetupAnimationState<seealso cref="M:BaseLib.Abstracts.CustomCharacterModel.SetupAnimationState(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite,System.String,System.String,System.Boolean,System.String,System.Boolean,System.String,System.Boolean,System.String,System.Boolean,System.String,System.Boolean)" /> is suggested.
	/// </summary>
	/// <returns></returns>
	public virtual CreatureAnimator? SetupCustomAnimationStates(MegaSprite controller)
	{
		return null;
	}

	/// <summary>
	/// If you have a Spine animation without all the required animations,
	/// use this method to set up a controller that will use animations of your choice for each animation.
	/// Any omitted animation parameters will default to the idle animation.
	/// </summary>
	/// <param name="controller"></param>
	/// <param name="idleName"></param>
	/// <param name="deadName"></param>
	/// <param name="deadLoop"></param>
	/// <param name="hitName"></param>
	/// <param name="hitLoop"></param>
	/// <param name="attackName"></param>
	/// <param name="attackLoop"></param>
	/// <param name="castName"></param>
	/// <param name="castLoop"></param>
	/// <param name="relaxedName"></param>
	/// <param name="relaxedLoop"></param>
	/// <returns></returns>
	public static CreatureAnimator SetupAnimationState(MegaSprite controller, string idleName, string? deadName = null, bool deadLoop = false, string? hitName = null, bool hitLoop = false, string? attackName = null, bool attackLoop = false, string? castName = null, bool castLoop = false, string? relaxedName = null, bool relaxedLoop = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		AnimState val = new AnimState(idleName, true);
		AnimState val2 = (AnimState)((deadName == null) ? ((object)val) : ((object)new AnimState(deadName, deadLoop)));
		AnimState val3 = (AnimState)((hitName == null) ? ((object)val) : ((object)new AnimState(hitName, hitLoop)
		{
			NextState = val
		}));
		AnimState val4 = (AnimState)((attackName == null) ? ((object)val) : ((object)new AnimState(attackName, attackLoop)
		{
			NextState = val
		}));
		AnimState val5 = (AnimState)((castName == null) ? ((object)val) : ((object)new AnimState(castName, castLoop)
		{
			NextState = val
		}));
		AnimState val6;
		if (relaxedName == null)
		{
			val6 = val;
		}
		else
		{
			val6 = new AnimState(relaxedName, relaxedLoop);
			val6.AddBranch("Idle", val, (Func<bool>)null);
		}
		CreatureAnimator val7 = new CreatureAnimator(val, controller);
		val7.AddAnyState("Idle", val, (Func<bool>)null);
		val7.AddAnyState("Dead", val2, (Func<bool>)null);
		val7.AddAnyState("Hit", val3, (Func<bool>)null);
		val7.AddAnyState("Attack", val4, (Func<bool>)null);
		val7.AddAnyState("Cast", val5, (Func<bool>)null);
		val7.AddAnyState("Relaxed", val6, (Func<bool>)null);
		return val7;
	}

	public void RegisterSceneConversions()
	{
		CustomVisualPath?.RegisterSceneForConversion<NCreatureVisuals>((Action<NCreatureVisuals>?)null);
		CustomRestSiteAnimPath?.RegisterSceneForConversion<NRestSiteCharacter>((Action<NRestSiteCharacter>?)null);
		CustomMerchantAnimPath?.RegisterSceneForConversion<NMerchantCharacter>((Action<NMerchantCharacter>?)null);
		CustomEnergyCounterPath?.RegisterSceneForConversion<NEnergyCounter>((Action<NEnergyCounter>?)null);
	}
}
