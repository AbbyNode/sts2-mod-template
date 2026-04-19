using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Godot;
using MegaCrit.Sts2.Core.Settings;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public struct SettingsDataMetric
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("buildId")]
	public required extern string BuildId
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("os")]
	public extern string Os
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("platform")]
	public extern string Platform
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("systemRam")]
	public extern int SystemRam
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("language")]
	public extern string LanguageCode
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("combatSpeed")]
	public required extern FastModeType FastModeType
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("screenshake")]
	public extern int Screenshake
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("runTimer")]
	public extern bool ShowRunTimer
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("cardIndices")]
	public extern bool ShowCardIndices
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("displayCount")]
	public extern int DisplayCount
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("displayResolution")]
	public extern Vector2I DisplayResolution
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("fullscreen")]
	public extern bool Fullscreen
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("aspectRatio")]
	public extern AspectRatioSetting AspectRatio
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("resizeWindows")]
	public extern bool ResizeWindows
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("vSync")]
	public extern VSyncType VSync
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("fpsLimit")]
	public extern int FpsLimit
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("msaa")]
	public extern int Msaa
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}
}
