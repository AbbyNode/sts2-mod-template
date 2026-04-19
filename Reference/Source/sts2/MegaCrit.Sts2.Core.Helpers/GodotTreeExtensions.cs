using Godot;

namespace MegaCrit.Sts2.Core.Helpers;

public static class GodotTreeExtensions
{
	public static extern void AddChildSafely(this Node parent, Node? child);

	public static extern void RemoveChildSafely(this Node parent, Node? child);

	public static extern void QueueFreeSafely(this Node node);

	public static extern void QueueFreeSafelyNoPool(this Node node);

	public static extern void FreeChildren(this Node node);
}
