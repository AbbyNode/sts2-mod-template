using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.DevConsole;

public class DevConsole
{
	public readonly FixedSizedQueue<string> history;

	public int historyIndex;

	public extern DevConsole(bool shouldAllowDebugCommands);

	public extern CompletionResult GetCompletionResults(string inputBuffer);

	public extern CmdResult ProcessCommand(string inputValue);

	public extern CmdResult ProcessNetCommand(Player? player, string inputValue);
}
