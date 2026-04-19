using System;
using System.Collections.Generic;
using BaseLib.Patches.Content;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomPotionModel : PotionModel, ICustomModel, ILocalizationProvider
{
	[HarmonyPatch(/*Could not decode attribute arguments.*/)]
	private static class ImagePatch
	{
		private static bool Prefix(PotionModel __instance, ref string? __result)
		{
			if (!(__instance is CustomPotionModel customPotionModel))
			{
				return true;
			}
			__result = customPotionModel.CustomPackedImagePath;
			return __result == null;
		}
	}

	[HarmonyPatch(/*Could not decode attribute arguments.*/)]
	private static class OutlinePatch
	{
		private static bool Prefix(PotionModel __instance, ref string? __result)
		{
			if (!(__instance is CustomPotionModel customPotionModel))
			{
				return true;
			}
			__result = customPotionModel.CustomPackedOutlinePath;
			return __result == null;
		}
	}

	[Obsolete("Pass value in constructor instead. Field will be deleted.")]
	public virtual bool AutoAdd => true;

	/// <summary>
	/// Override this or place your potion's image at
	/// "res://images/atlases/potion_atlas.sprites/modid-potion_name.tres"
	/// You may pass the path to a png or any other file that Godot can load as a Texture2D.
	/// </summary>
	public virtual string? CustomPackedImagePath => null;

	/// <summary>
	/// Override this or place your potion's outline image at
	/// "res://images/atlases/potion_outline_atlas.sprites/modid-potion_name.tres"
	/// You may pass the path to a png or any other file that Godot can load as a Texture2D.
	/// </summary>
	public virtual string? CustomPackedOutlinePath => null;

	/// <summary>
	/// Override this to define localization directly in your class.
	/// You are recommended to return a PotionLoc<seealso cref="T:BaseLib.Abstracts.PotionLoc" />.
	/// </summary>
	public virtual List<(string, string)>? Localization => null;

	public CustomPotionModel()
		: this(true)
	{
	}

	public CustomPotionModel(bool autoAdd = true)
	{
		if (autoAdd)
		{
			CustomContentDictionary.AddModel(((object)this).GetType());
		}
	}
}
