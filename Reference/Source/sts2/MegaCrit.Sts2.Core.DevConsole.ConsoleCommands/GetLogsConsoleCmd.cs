using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.DevConsole.ConsoleCommands;

public class GetLogsConsoleCmd : AbstractConsoleCmd
{
	public override extern string CmdName { get; }

	public override extern string Args { get; }

	public override extern string Description { get; }

	public override extern bool IsNetworked { get; }

	public override extern bool DebugOnly { get; }

	public override extern CmdResult Process(Player? issuingPlayer, string[] args);

	public static extern string GetBugReportPath(string extraName = "");

	[AsyncStateMachine(typeof(_003CGrabLogs_003Ed__16))]
	public static extern Task GrabLogs(string bugReportPath);

	public static extern void ZipFiles(Stream outputStream, byte[] screenshotBytes);

	public static extern void ZipFeedbackLogs(Stream outputStream, int profileId);

	public static extern string ReadTailText(Stream stream, long maxBytes);

	public extern GetLogsConsoleCmd();
}
