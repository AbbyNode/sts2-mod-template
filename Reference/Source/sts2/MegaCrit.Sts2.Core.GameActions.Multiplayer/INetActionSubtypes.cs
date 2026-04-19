using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public static class INetActionSubtypes
{
	public static extern int Count { get; }

	public static extern IReadOnlyList<Type> All { get; }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2063", Justification = "The list only contains types stored with the correct DynamicallyAccessedMembers attribute, enforced by source generation.")]
	public static extern Type Get(int i);
}
