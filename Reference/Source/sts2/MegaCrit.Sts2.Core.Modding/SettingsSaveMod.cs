using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MegaCrit.Sts2.Core.Modding;

public class SettingsSaveMod
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("id")]
	public extern string Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("source")]
	public extern ModSource Source
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("is_enabled")]
	public extern bool IsEnabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SettingsSaveMod();

	public extern SettingsSaveMod(Mod mod);
}
