using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.Extensions;

public static class SignalAwaiterExtensions
{
	[AsyncStateMachine(typeof(_003CToTask_003Ed__0))]
	public static extern Task ToTask(this SignalAwaiter awaiter);
}
