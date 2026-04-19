using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Platform.Null;

public class NullLeaderboardFile : ISaveSchema
{
	[JsonPropertyName("leaderboards")]
	public List<NullLeaderboard> leaderboards;

	[JsonPropertyName("version")]
	public extern int SchemaVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern NullLeaderboardFile();
}
