using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Models;

public class DeterministicModelComparer : IComparer<AbstractModel>
{
	public static extern DeterministicModelComparer Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern int Compare(AbstractModel? model1, AbstractModel? model2);
}
