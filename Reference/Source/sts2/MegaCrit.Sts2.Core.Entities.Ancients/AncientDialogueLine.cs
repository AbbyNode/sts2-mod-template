using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.Ancients;

public class AncientDialogueLine
{
	public const string sfxFallbackPath = "event:/sfx/ui/enchant_simple";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString? LineText
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern LocString? NextButtonText
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern AncientDialogueSpeaker Speaker
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern AncientDialogueLine(string sfxPath);

	public extern string GetSfxOrFallbackPath();
}
