using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

public static class NodeUtil
{
	public static extern bool IsDescendant(Node parent, Node candidate);

	public static extern bool IsValid(this Node? node);

	public static extern void TryGrabFocus(this Control control);

	public static extern T? GetAncestorOfType<T>(this Node node);

	[IteratorStateMachine(typeof(_003CGetChildrenRecursive_003Ed__4<>))]
	public static extern IEnumerable<T> GetChildrenRecursive<T>(this Node node);
}
