using System;
using System.Collections.Generic;
using System.Reflection;
using BaseLib.Abstracts;
using BaseLib.Utils;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Content;

[HarmonyPatch(typeof(ModelDb), "InitIds")]
public static class CustomContentDictionary
{
	public static readonly HashSet<Type> RegisteredTypes;

	private static readonly Dictionary<Type, Type> PoolTypes;

	public static readonly List<CustomEncounterModel> CustomEncounters;

	public static readonly List<CustomAncientModel> CustomAncients;

	/// <summary>
	/// Custom events tied to a specific act.
	/// </summary>
	public static readonly List<CustomEventModel> ActCustomEvents;

	/// <summary>
	/// Custom events not tied to a specific act.
	/// </summary>
	public static readonly List<CustomEventModel> SharedCustomEvents;

	static CustomContentDictionary()
	{
		RegisteredTypes = new HashSet<Type>();
		PoolTypes = new Dictionary<Type, Type>();
		CustomEncounters = new List<CustomEncounterModel>();
		CustomAncients = new List<CustomAncientModel>();
		ActCustomEvents = new List<CustomEventModel>();
		SharedCustomEvents = new List<CustomEventModel>();
		PoolTypes.Add(typeof(CardPoolModel), typeof(CardModel));
		PoolTypes.Add(typeof(RelicPoolModel), typeof(RelicModel));
		PoolTypes.Add(typeof(PotionPoolModel), typeof(PotionModel));
	}

	public static bool RegisterType(Type t)
	{
		return RegisteredTypes.Add(t);
	}

	public static void AddModel(Type modelType)
	{
		if (RegisterType(modelType))
		{
			PoolAttribute poolAttribute = modelType.GetCustomAttribute<PoolAttribute>() ?? throw new Exception("Model " + modelType.FullName + " must be marked with a PoolAttribute to determine which pool to add it to.");
			if (!IsValidPool(modelType, poolAttribute.PoolType))
			{
				throw new Exception($"Model {modelType.FullName} is assigned to incorrect type of pool {poolAttribute.PoolType.FullName}.");
			}
			ModHelper.AddModelToPool(poolAttribute.PoolType, modelType);
		}
	}

	public static void AddEncounter(CustomEncounterModel encounter)
	{
		if (RegisterType(((object)encounter).GetType()))
		{
			CustomEncounters.Add(encounter);
		}
	}

	public static void AddAncient(CustomAncientModel ancient)
	{
		if (RegisterType(((object)ancient).GetType()))
		{
			CustomAncients.Add(ancient);
		}
	}

	public static void AddEvent(CustomEventModel eventModel)
	{
		if (RegisterType(((object)eventModel).GetType()))
		{
			if (eventModel.Acts.Length == 0)
			{
				SharedCustomEvents.Add(eventModel);
			}
			else
			{
				ActCustomEvents.Add(eventModel);
			}
		}
	}

	private static bool IsValidPool(Type modelType, Type poolType)
	{
		Type baseType = poolType.BaseType;
		while (baseType != null)
		{
			if (PoolTypes.TryGetValue(baseType, out Type value))
			{
				return modelType.IsAssignableTo(value);
			}
			baseType = baseType.BaseType;
		}
		throw new Exception($"Model {modelType.FullName} is assigned to {poolType.FullName} which is not a valid pool type.");
	}
}
