using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.GameInfo.Objects;

[Serializable]
public class Keywords : IGameInfo
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("name")]
	public required extern string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("bot_keyword")]
	public required extern string BotKeyword
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("bot_text")]
	public required extern string BotText
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern Keywords();
}
