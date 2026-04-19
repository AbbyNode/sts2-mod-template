using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.HoverTips;

public static class HoverTipExtensions
{
	public static extern void MegaTryAddingTip(this ICollection<IHoverTip> tips, IHoverTip tip);
}
