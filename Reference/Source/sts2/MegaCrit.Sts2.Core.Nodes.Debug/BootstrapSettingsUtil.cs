using System;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.Nodes.Debug;

public static class BootstrapSettingsUtil
{
	[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
	public static extern Type? Get();
}
