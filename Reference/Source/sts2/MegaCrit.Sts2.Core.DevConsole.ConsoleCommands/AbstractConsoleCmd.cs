using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.DevConsole.ConsoleCommands;

public abstract class AbstractConsoleCmd
{
	public abstract string CmdName { get; }

	public abstract string Args { get; }

	public abstract string Description { get; }

	public abstract bool IsNetworked { get; }

	public virtual extern bool DebugOnly { get; }

	public abstract CmdResult Process(Player? issuingPlayer, string[] args);

	public virtual extern CompletionResult GetArgumentCompletions(Player? player, string[] args);

	protected extern CompletionResult CompleteArgument(IEnumerable<string> candidates, string[] completedArgs, string partialArg, CompletionType type = CompletionType.Argument, Func<string, string, bool>? matchPredicate = null);

	protected extern string BuildPrefix(string[] completedArgs);

	protected static extern bool TryParseEnum<T>(string input, out T result) where T : struct, Enum;

	protected extern AbstractConsoleCmd();
}
