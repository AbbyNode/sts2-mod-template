using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.AutoSlay.Helpers;

public static class UiHelper
{
	[AsyncStateMachine(typeof(_003CClick_003Ed__0))]
	public static extern Task Click(NClickableControl button, int delayMs = 100);

	public static extern List<T> FindAll<T>(Node start) where T : Node;

	public static extern T? FindFirst<T>(Node start) where T : Node;
}
