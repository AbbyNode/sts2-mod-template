using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Modding;

public class ModSettings
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("mods_enabled")]
	public extern bool PlayerAgreedToModLoading
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("mod_list")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<SettingsSaveMod> ModList
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsModDisabled(Mod mod);

	public extern bool IsModDisabled(string? id, ModSource source);

	public extern ModSettings();
}
