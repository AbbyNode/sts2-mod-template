using System;
using System.Collections.Generic;
using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;

namespace BaseLib.Utils;

public class CustomBackgroundAssets : BackgroundAssets
{
	private static readonly MethodInfo BackgroundScenePathSetter = AccessTools.PropertySetter(typeof(BackgroundAssets), "BackgroundScenePath");

	private static readonly MethodInfo FgLayerSetter = AccessTools.PropertySetter(typeof(BackgroundAssets), "FgLayer");

	private const string FakeKey = "glory";

	public CustomBackgroundAssets(string layersPath, string bgScenePath, Rng rng)
		: base("glory", Rng.Chaotic)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((BackgroundAssets)this).BgLayers.Clear();
		DirAccess val = DirAccess.Open(layersPath);
		try
		{
			if (val == null)
			{
				throw new InvalidOperationException("could not find directory " + layersPath);
			}
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			List<string> list = new List<string>();
			val.ListDirBegin();
			string next = val.GetNext();
			while (next != "")
			{
				if (val.CurrentIsDir())
				{
					throw new InvalidOperationException("there should be no other directories within the layers directory");
				}
				if (next.Contains("_fg_"))
				{
					list.Add(layersPath + "/" + next);
				}
				else
				{
					if (!next.Contains("_bg_"))
					{
						throw new InvalidOperationException("files must either contain '_fg_' or '_bg_'");
					}
					string key = next.Split("_bg_")[1].Split("_")[0];
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, new List<string>());
					}
					dictionary[key].Add(layersPath + "/" + next);
				}
				next = val.GetNext();
			}
			BackgroundScenePathSetter.Invoke(this, new object[1] { bgScenePath });
			((BackgroundAssets)this).BgLayers.AddRange(BackgroundAssets.SelectRandomBackgroundAssetLayers(rng, dictionary));
			FgLayerSetter.Invoke(this, new object[1] { BackgroundAssets.SelectRandomForegroundAssetLayer(rng, (IEnumerable<string>)list) });
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
