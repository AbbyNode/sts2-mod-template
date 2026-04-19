using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.HoverTips;

public interface IHoverTip
{
	string Id { get; }

	bool IsSmart { get; }

	bool IsDebuff { get; }

	bool IsInstanced { get; }

	AbstractModel? CanonicalModel { get; }

	static IEnumerable<IHoverTip> RemoveDupes(IEnumerable<IHoverTip> tips);
}
