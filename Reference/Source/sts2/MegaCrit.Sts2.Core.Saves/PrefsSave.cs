using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Settings;

namespace MegaCrit.Sts2.Core.Saves;

public class PrefsSave : ISaveSchema
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

	[JsonPropertyName("fast_mode")]
	public extern FastModeType FastMode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("screenshake")]
	public extern int ScreenShakeOptionIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("show_run_timer")]
	public extern bool ShowRunTimer
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("show_card_indices")]
	public extern bool ShowCardIndices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("upload_data")]
	public extern bool UploadData
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("mute_in_background")]
	public extern bool MuteInBackground
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("long_press")]
	public extern bool IsLongPressEnabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("text_effects_enabled")]
	public extern bool TextEffectsEnabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern PrefsSave();
}
