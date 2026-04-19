using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Godot;
using MegaCrit.Sts2.Core.ControllerInput;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Settings;

namespace MegaCrit.Sts2.Core.Saves;

public class SettingsSave : ISaveSchema
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("schema_version")]
	public extern int SchemaVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("fps_limit")]
	public extern int FpsLimit
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("language")]
	public extern string? Language
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("window_position")]
	public extern Vector2I WindowPosition
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("window_size")]
	public extern Vector2I WindowSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("fullscreen")]
	public extern bool Fullscreen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("aspect_ratio")]
	public extern AspectRatioSetting AspectRatioSetting
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("target_display")]
	public extern int TargetDisplay
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("resize_windows")]
	public extern bool ResizeWindows
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("vsync")]
	public extern VSyncType VSync
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("msaa")]
	public extern int Msaa
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("volume_bgm")]
	public extern float VolumeBgm
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("volume_master")]
	public extern float VolumeMaster
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("volume_sfx")]
	public extern float VolumeSfx
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("volume_ambience")]
	public extern float VolumeAmbience
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("mod_settings")]
	public extern ModSettings? ModSettings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("skip_intro_logo")]
	public extern bool SkipIntroLogo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("keyboard_mapping")]
	public extern Dictionary<string, string> KeyboardMapping
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("controller_mapping_type")]
	public extern ControllerMappingType ControllerMappingType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("controller_mapping")]
	public extern Dictionary<string, string> ControllerMapping
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("limit_fps_in_background")]
	public extern bool LimitFpsInBackground
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("full_console")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern bool FullConsole
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("seen_ea_disclaimer")]
	public extern bool SeenEaDisclaimer
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SettingsSave();
}
