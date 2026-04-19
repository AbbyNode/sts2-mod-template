using System.Runtime.CompilerServices;
using SmartFormat.Core.Extensions;

namespace MegaCrit.Sts2.Core.Localization.Formatters;

public class PercentLessFormatter : IFormatter
{
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

	public extern PercentLessFormatter();
}
