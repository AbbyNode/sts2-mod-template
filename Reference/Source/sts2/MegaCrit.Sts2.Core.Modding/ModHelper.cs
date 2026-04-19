using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Modding;

public static class ModHelper
{
	public static extern void AddModelToPool<TPoolType, TModelType>() where TPoolType : AbstractModel, IPoolModel where TModelType : AbstractModel;

	public static extern void AddModelToPool(Type poolType, Type modelType);

	public static extern IEnumerable<TModelType> ConcatModelsFromMods<TModelType>(IPoolModel poolModel, IEnumerable<TModelType> pool) where TModelType : AbstractModel;
}
