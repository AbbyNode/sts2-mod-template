using System;
using System.Collections.Generic;
using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Helpers;

namespace BaseLib.Utils;

public class AddedNode<TParentType, TNode> : SpireField<TParentType, TNode> where TParentType : Node where TNode : Node
{
	private static List<AddedNode<TParentType, TNode>> _addedNodes = new List<AddedNode<TParentType, TNode>>();

	private static bool _patched = false;

	public AddedNode(Func<TParentType, TNode> defaultVal)
		: base(defaultVal)
	{
		_addedNodes.Add(this);
		PatchNodeReady();
	}

	public AddedNode(string scenePath, Action<TParentType, TNode>? extraSetup = null)
		: this((Func<TParentType, TNode>)delegate(TParentType parent)
		{
			TNode val = SceneHelper.Instantiate<TNode>(scenePath);
			extraSetup?.Invoke(parent, val);
			return val;
		})
	{
	}

	private void PatchNodeReady()
	{
		if (_patched)
		{
			return;
		}
		_patched = true;
		Harmony mainHarmony = BaseLibMain.MainHarmony;
		MethodInfo methodInfo = AccessTools.DeclaredMethod(typeof(TParentType), "_Ready", Array.Empty<Type>(), (Type[])null);
		if (methodInfo != null)
		{
			mainHarmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, HarmonyMethod.op_Implicit(AccessToolsExtensions.DeclaredMethod(GetType(), "UnconditionalAdd", (Type[])null, (Type[])null)), (HarmonyMethod)null, (HarmonyMethod)null);
			BaseLibMain.Logger.Info($"Patched type {typeof(TParentType).Name} to add {typeof(TNode).Name}.", 1);
			return;
		}
		methodInfo = AccessTools.Method(typeof(TParentType), "_Ready", Array.Empty<Type>(), (Type[])null);
		if (methodInfo == null)
		{
			BaseLibMain.Logger.Error($"Failed to patch _Ready method for type {typeof(TParentType).Name} to add node {typeof(TNode).Name}; _Ready method not found.", 1);
		}
		else
		{
			mainHarmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, HarmonyMethod.op_Implicit(AccessToolsExtensions.DeclaredMethod(GetType(), "ConditionalAdd", (Type[])null, (Type[])null)), (HarmonyMethod)null, (HarmonyMethod)null);
			BaseLibMain.Logger.Info($"Patched type {typeof(TParentType).Name} to add {typeof(TNode).Name}.", 1);
		}
	}

	private static void UnconditionalAdd(TParentType __instance)
	{
		foreach (AddedNode<TParentType, TNode> addedNode in _addedNodes)
		{
			TNode val = addedNode.Get(__instance);
			if (((Node)__instance).IsAncestorOf((Node)(object)val))
			{
				break;
			}
			((Node)__instance).AddChild((Node)(object)val, false, (InternalMode)0);
		}
	}

	private static void ConditionalAdd(object __instance)
	{
		TParentType val = (TParentType)((__instance is TParentType) ? __instance : null);
		if (val != null)
		{
			UnconditionalAdd(val);
		}
	}
}
