using BaseLib.Extensions;
using MegaCrit.Sts2.Core.Localization.DynamicVars;

namespace BaseLib.Cards.Variables;

/// <summary>
/// A calculated var that allows multiple on a single model and works on relics and powers.
/// </summary>
public class CustomCalculatedVar : CalculatedVar
{
	public CustomCalculatedVar(string name)
		: base(name)
	{
		BaseLibMain.Logger.Info("CustomCalculatedVar: " + ((DynamicVar)this).Name, 1);
	}

	protected override DynamicVar GetBaseVar()
	{
		return ((DynamicVar)this)._owner.GetDynamicVar(((DynamicVar)this).Name + "Base");
	}

	protected override DynamicVar GetExtraVar()
	{
		return ((DynamicVar)this)._owner.GetDynamicVar(((DynamicVar)this).Name + "Extra");
	}
}
