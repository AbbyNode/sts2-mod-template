using System;
using System.Collections.Generic;
using BaseLib.Patches.Content;
using BaseLib.Patches.UI;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomRelicPoolModel : RelicPoolModel, ICustomModel, ICustomEnergyIconPool
{
	/// <summary>
	/// You shouldn't need this (just use SharedRelicPool), but it is allowed.
	/// </summary>
	public virtual bool IsShared => false;

	public override string EnergyColorName => CustomEnergyIconPatches.GetEnergyColorName(((AbstractModel)this).Id);

	public virtual string? BigEnergyIconPath => null;

	public virtual string? TextEnergyIconPath => null;

	public CustomRelicPoolModel()
	{
		if (IsShared)
		{
			ModelDbSharedRelicPoolsPatch.Register(this);
		}
	}

	protected override IEnumerable<RelicModel> GenerateAllRelics()
	{
		return Array.Empty<RelicModel>();
	}
}
