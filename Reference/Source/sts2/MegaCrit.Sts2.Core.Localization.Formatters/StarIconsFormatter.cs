using System.Runtime.CompilerServices;
using SmartFormat.Core.Extensions;

namespace MegaCrit.Sts2.Core.Localization.Formatters;

public class StarIconsFormatter : IFormatter
{
	public const string starIconSprite = "[img]res://images/packed/sprite_fonts/star_icon.png[/img]";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string Name { get; set; }

	public extern bool CanAutoDetect
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool TryEvaluateFormat(IFormattingInfo formattingInfo);

	public extern StarIconsFormatter();
}
