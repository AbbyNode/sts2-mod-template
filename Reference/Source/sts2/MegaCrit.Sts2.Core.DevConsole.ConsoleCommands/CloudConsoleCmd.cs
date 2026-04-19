using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.DevConsole.ConsoleCommands;

public class CloudConsoleCmd : AbstractConsoleCmd
{
	public override extern string CmdName { get; }

	public override extern string Args { get; }

	public override extern string Description { get; }

	public override extern bool IsNetworked { get; }

	public override extern bool DebugOnly { get; }

	public override extern CmdResult Process(Player? issuingPlayer, string[] args);

	public static extern void DeleteCloudSaves();

	public extern CloudConsoleCmd();
}
