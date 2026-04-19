using System;
using BaseLib.Utils.NodeFactories;
using Godot;

namespace BaseLib.Extensions;

public static class StringExtensions
{
	public static string RemovePrefix(this string id)
	{
		int num = id.IndexOf('-') + 1;
		return id.Substring(num, id.Length - num);
	}

	/// <summary>
	/// Registers a scene to be automatically converted to the specified node type when instantiated.
	/// Requires a factory to exist in NodeFactory<seealso cref="T:BaseLib.Utils.NodeFactories.NodeFactory" /> to perform the conversion to the specified type.
	/// </summary>
	public static void RegisterSceneForConversion<TNode>(this string scenePath, Action<TNode>? postConversion = null) where TNode : Node
	{
		NodeFactory.RegisterSceneType(scenePath, postConversion);
	}
}
