using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.GameInfo.Objects;

[Serializable]
public class CardInfo : IGameInfo
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

	[JsonPropertyName("id")]
	public required extern ModelId Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("upgraded")]
	public required extern bool Upgraded
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("color")]
	public required extern string Color
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("rarity")]
	public required extern string Rarity
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("type")]
	public required extern string Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("base_damage")]
	public required extern int BaseDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("energy")]
	public required extern int Energy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("star_cost")]
	public required extern int StarCost
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("text")]
	public required extern string Text
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("has_art")]
	public required extern bool HasArt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("has_joke_art")]
	public required extern bool HasJokeArt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern CardInfo();
}
