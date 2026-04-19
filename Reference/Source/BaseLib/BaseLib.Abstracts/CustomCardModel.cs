using System.Collections.Generic;
using System.Linq;
using BaseLib.Patches.Content;
using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomCardModel : CardModel, ICustomModel, ILocalizationProvider
{
	private bool _initializedFrameMaterial;

	private Material? _frameMaterial;

	/// <summary>
	/// For convenience; can be manually overridden if necessary.
	/// </summary>
	public override bool GainsBlock => ((IEnumerable<KeyValuePair<string, DynamicVar>>)((CardModel)this).DynamicVars).Any(delegate(KeyValuePair<string, DynamicVar> dynVar)
	{
		DynamicVar value = dynVar.Value;
		return (value is BlockVar || value is CalculatedBlockVar) ? true : false;
	});

	/// <summary>
	/// Allows a custom texture to be used as the card's back frame.
	/// A new texture loaded through ResourceLoader.Load&lt;Texture2D&gt; should be returned.
	/// </summary>
	public virtual Texture2D? CustomFrame => null;

	/// <summary>
	/// Returns a custom ShaderMaterial defined by CreateCustomFrameMaterial.
	/// </summary>
	public Material? CustomFrameMaterial
	{
		get
		{
			if (!_initializedFrameMaterial)
			{
				_frameMaterial = CreateCustomFrameMaterial;
				_initializedFrameMaterial = true;
			}
			return _frameMaterial;
		}
	}

	/// <summary>
	/// Override this to use a custom ShaderMaterial only for this card.<seealso cref="M:BaseLib.Utils.ShaderUtils.GenerateHsv(System.Single,System.Single,System.Single)" />
	/// </summary>
	public virtual Material? CreateCustomFrameMaterial => null;

	public virtual string? CustomPortraitPath => null;

	public virtual Texture2D? CustomPortrait => null;

	public virtual List<(string, string)>? Localization => null;

	public CustomCardModel(int baseCost, CardType type, CardRarity rarity, TargetType target, bool showInCardLibrary = true, bool autoAdd = true)
		: base(baseCost, type, rarity, target, showInCardLibrary)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (autoAdd)
		{
			CustomContentDictionary.AddModel(((object)this).GetType());
		}
	}
}
