using System;
using BaseLib.Extensions;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.ValueProps;

namespace BaseLib.Cards.Variables;

/// <summary>
/// A CalculatedDamageVar that allows a custom name and can have multiple on one model.
/// Also works on relics and powers.
/// </summary>
public class CustomCalculatedDamageVar : CalculatedDamageVar
{
	private static Action<DynamicVar, string>? _nameSetter = ReflectionUtils.GetSetterForProperty<DynamicVar, string>("Name");

	public CustomCalculatedDamageVar(string name, ValueProp props)
		: base(props)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_nameSetter?.Invoke((DynamicVar)(object)this, name);
		BaseLibMain.Logger.Info("CustomCalculatedDamageVar: " + ((DynamicVar)this).Name, 1);
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
