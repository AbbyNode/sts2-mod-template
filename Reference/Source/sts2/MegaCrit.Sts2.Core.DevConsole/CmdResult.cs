using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.DevConsole;

public struct CmdResult
{
	public readonly bool success;

	public readonly string msg;

	public readonly Task? task;

	public extern CmdResult(bool success, string? msg = null);

	public extern CmdResult(Task task, bool success, string? msg = null);
}
