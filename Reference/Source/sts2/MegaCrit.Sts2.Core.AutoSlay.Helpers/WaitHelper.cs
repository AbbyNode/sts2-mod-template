using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.AutoSlay.Helpers;

public static class WaitHelper
{
	[AsyncStateMachine(typeof(_003CUntil_003Ed__0))]
	public static extern Task Until(Func<bool> condition, CancellationToken ct, TimeSpan? timeout = null, string? timeoutMessage = null);

	[AsyncStateMachine(typeof(_003CForNode_003Ed__1<>))]
	public static extern Task<T> ForNode<T>(Node root, string nodePath, CancellationToken ct, TimeSpan? timeout = null) where T : Node;

	[AsyncStateMachine(typeof(_003CForTask_003Ed__4))]
	public static extern Task ForTask(Task task, CancellationToken ct, TimeSpan? timeout = null, string? timeoutMessage = null);

	[AsyncStateMachine(typeof(_003CWithTimeout_003Ed__5))]
	public static extern Task WithTimeout(Func<CancellationToken, Task> action, TimeSpan timeout, CancellationToken ct);
}
