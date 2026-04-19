using System;

namespace MegaCrit.Sts2.Core.Modding;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class ModInitializerAttribute : Attribute
{
	public string initializerMethod;

	public extern ModInitializerAttribute(string initializerMethod);
}
