using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.Timeline;

public static class StoryModelSubtypes
{
	public static extern int Count { get; }

	public static extern IReadOnlyList<Type> All { get; }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2063", Justification = "The list only contains types stored with the correct DynamicallyAccessedMembers attribute, enforced by source generation.")]
	[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties)]
	public static extern Type Get(int i);
}
