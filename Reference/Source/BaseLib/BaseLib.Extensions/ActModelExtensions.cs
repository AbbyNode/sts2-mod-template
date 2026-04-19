using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Acts;

namespace BaseLib.Extensions;

public static class ActModelExtensions
{
	public static int ActNumber(this ActModel actModel)
	{
		if (!(actModel is Overgrowth) && !(actModel is Underdocks))
		{
			if (!(actModel is Hive))
			{
				if (actModel is Glory)
				{
					return 3;
				}
				return -1;
			}
			return 2;
		}
		return 1;
	}
}
