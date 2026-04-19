using System.Collections.Generic;
using BaseLib.Patches.Content;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomRelicModel : RelicModel, ICustomModel, ILocalizationProvider
{
	/// <summary>
	/// Override this to define localization directly in your class.
	/// You are recommended to return a RelicLoc<seealso cref="T:BaseLib.Abstracts.RelicLoc" />.
	/// </summary>
	public virtual List<(string, string)>? Localization => null;

	public CustomRelicModel(bool autoAdd = true)
	{
		if (autoAdd)
		{
			CustomContentDictionary.AddModel(((object)this).GetType());
		}
	}

	public virtual RelicModel? GetUpgradeReplacement()
	{
		return null;
	}
}
