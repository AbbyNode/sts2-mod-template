using System;
using BaseLib.Patches.Content;
using BaseLib.Patches.UI;
using Godot;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomCardPoolModel : CardPoolModel, ICustomModel, ICustomEnergyIconPool
{
	/// <summary>
	/// Material is a shader material that will be applied to the frame texture. A custom frame can be used by overriding <seealso cref="M:BaseLib.Abstracts.CustomCardPoolModel.CustomFrame(BaseLib.Abstracts.CustomCardModel)" />.
	/// Override this only if you have a custom shadermaterial.
	/// If not overridden, a custom material will be automatically defined using <seealso cref="P:BaseLib.Abstracts.CustomCardPoolModel.ShaderColor" />.
	/// </summary>
	public override string CardFrameMaterialPath => "card_frame_red";

	/// <summary>
	/// Used for HSV values of material shader.
	/// HSV can instead be overridden directly.
	/// </summary>
	public virtual Color ShaderColor => new Color("FFFFFF");

	public virtual float H
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Color shaderColor = ShaderColor;
			return ((Color)(ref shaderColor)).H;
		}
	}

	public virtual float S
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Color shaderColor = ShaderColor;
			return ((Color)(ref shaderColor)).S;
		}
	}

	public virtual float V
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Color shaderColor = ShaderColor;
			return ((Color)(ref shaderColor)).V;
		}
	}

	/// <summary>
	/// Should be true for a pool not tied to a specific character, like the Curse or Status pool.
	/// </summary>
	public virtual bool IsShared => false;

	/// <summary>
	/// Override this to load a custom tres from `images/atlases/ui_atlas.sprites/card/energy_{EnergyColorName}.tres`
	/// Otherwise, override BigEnergyIconPath and TextEnergyIconPath.
	/// </summary>
	public override string EnergyColorName => CustomEnergyIconPatches.GetEnergyColorName(((AbstractModel)this).Id);

	/// <summary>
	/// Override and provide a .tres or .png or similar
	/// </summary>
	public virtual string? BigEnergyIconPath => null;

	public virtual string? TextEnergyIconPath => null;

	public CustomCardPoolModel()
	{
		if (IsShared)
		{
			ModelDbSharedCardPoolsPatch.Register(this);
		}
	}

	/// <summary>
	/// Back image of a card. Not required; basegame cards all use the same frames, colored using a shader.
	/// Ancient rarity uses a separate frame that ignores this logic.
	/// </summary>
	/// <param name="card"></param>
	/// <returns></returns>
	public virtual Texture2D? CustomFrame(CustomCardModel card)
	{
		return null;
	}

	/// <summary>
	/// Returns all cards contained in the pool. This method does not need to be overriden if you are using
	/// CustomCardModel; content will be added through ModHelper.ConcatModelsFromMods
	/// </summary>
	/// <returns></returns>
	protected override CardModel[] GenerateAllCards()
	{
		return Array.Empty<CardModel>();
	}
}
