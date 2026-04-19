using BaseLib.Patches.Content;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;

namespace BaseLib.Abstracts;

public abstract class CustomEncounterModel : EncounterModel, ICustomModel
{
	[HarmonyPatch(/*Could not decode attribute arguments.*/)]
	private static class ScenePathPatch
	{
		[HarmonyPrefix]
		private static bool Custom(EncounterModel __instance, ref string? __result)
		{
			if (!(__instance is CustomEncounterModel customEncounterModel))
			{
				return true;
			}
			__result = customEncounterModel.CustomScenePath;
			return __result == null;
		}
	}

	[HarmonyPatch(typeof(EncounterModel), "GetBackgroundAssets")]
	private static class GetCustomBackgroundAssets
	{
		[HarmonyPrefix]
		private static void Custom(EncounterModel __instance, ActModel parentAct, Rng rng)
		{
			if (__instance is CustomEncounterModel customEncounterModel)
			{
				customEncounterModel.PrepCustomBackground(parentAct, rng);
			}
		}
	}

	[HarmonyPatch(typeof(EncounterModel), "CreateBackgroundAssetsForCustom")]
	private static class ScenePatch
	{
		[HarmonyPrefix]
		private static bool Custom(EncounterModel __instance, ref BackgroundAssets? __result)
		{
			if (!(__instance is CustomEncounterModel customEncounterModel))
			{
				return true;
			}
			__result = customEncounterModel._customBackgroundAssets;
			return __result == null;
		}
	}

	private BackgroundAssets? _customBackgroundAssets;

	public override RoomType RoomType { get; }

	/// <summary>
	/// The path to an encounter scene.
	/// An encounter scene is a 1920x1080 Control with Full Rect anchors, and Marker2D children for enemy positions.
	/// The names of these markers can be used with CreatureCmd.Add when spawning additional enemies.
	/// Initial enemies will be placed at these markers in the order they exist in the scene.
	/// </summary>
	public virtual string? CustomScenePath => null;

	/// <summary>
	/// Should not be necessary to override; will return true if CustomScenePath returns a valid resource path or
	/// a scene exists at the basegame expected path res://scenes/encounters/modname-encounter_name.tscn
	/// </summary>
	public override bool HasScene
	{
		get
		{
			if (CustomScenePath == null || !ResourceLoader.Exists(CustomScenePath, ""))
			{
				return ResourceLoader.Exists(((EncounterModel)this).ScenePath, "");
			}
			return true;
		}
	}

	/// <summary>
	/// Works automatically if CustomEncounterBackground is overridden.
	/// If not using CustomEncounterBackground and instead placing files in basegame expected paths,
	/// override this to return true.
	/// </summary>
	protected override bool HasCustomBackground => _customBackgroundAssets != null;

	/// <summary>
	/// See RoomIconPathPatch<seealso cref="T:BaseLib.Patches.UI.RoomIconPathPatch" />
	/// </summary>
	public virtual string? CustomRunHistoryIconPath => null;

	public virtual string? CustomRunHistoryIconOutlinePath => null;

	protected CustomEncounterModel(RoomType roomType, bool autoAdd = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (roomType - 1 > 2)
		{
			BaseLibMain.Logger.Warn($"Encounter {((AbstractModel)this).Id.Entry} sets unexpected room type {roomType}", 1);
		}
		RoomType = roomType;
		if (autoAdd)
		{
			CustomContentDictionary.AddEncounter(this);
		}
	}

	public abstract bool IsValidForAct(ActModel act);

	/// <summary>
	/// Generates and stores a custom background.
	/// </summary>
	/// <param name="parentAct"></param>
	/// <param name="rng"></param>
	protected void PrepCustomBackground(ActModel parentAct, Rng rng)
	{
		_customBackgroundAssets = CustomEncounterBackground(parentAct, rng);
	}

	/// <summary>
	/// Override this method if you want to provide a custom encounter background for your scene using custom paths.
	/// To do so, return a new CustomBackgroundAssets object.
	/// Alternatively you can place your assets at res://scenes/backgrounds/modname-encounter_name/layers and
	/// res://scenes/backgrounds/modname-encounter_name/modname-encounter_name_background.tscn, then override 
	/// </summary>
	public virtual BackgroundAssets? CustomEncounterBackground(ActModel parentAct, Rng rng)
	{
		return null;
	}
}
