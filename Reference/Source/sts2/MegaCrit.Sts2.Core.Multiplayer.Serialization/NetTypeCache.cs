using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public class NetTypeCache<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TBase> where TBase : class
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetTypeCache(List<Type> types);

	public extern int TypeToId<T>() where T : TBase;

	public extern int TypeToId(Type type);

	public extern bool TryGetTypeFromId(int id, out Type? type);
}
