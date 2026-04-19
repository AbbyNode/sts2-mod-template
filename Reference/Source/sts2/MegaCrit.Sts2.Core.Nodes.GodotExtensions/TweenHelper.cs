using System.Threading;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

public static class TweenHelper
{
	public static extern void FastForwardToCompletion(this Tween t);

	public static extern Task AwaitFinished(this Tween tween, CancellationToken ct);
}
