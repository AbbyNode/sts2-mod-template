using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Helpers;

public static class EnergyIconHelper
{
	public static extern string GetPrefix(AbstractModel model);

	public static extern string GetPath(AbstractModel model);

	public static extern string GetPath(string prefix);
}
