using System;
using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Nodes.Pooling;

public class NodePool
{
	public static extern NodePool<T> Init<T>(string scenePath, int prewarmCount) where T : Node, IPoolable;

	public static extern IPoolable Get(Type type);

	public static extern void Free(IPoolable poolable);

	public static extern T Get<T>() where T : Node, IPoolable;

	public static extern void Free<T>(T obj) where T : Node, IPoolable;

	public extern NodePool();
}
public class NodePool<T> : INodePool where T : Node, IPoolable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<T> DebugFreeObjects { get; }

	public extern NodePool(string scenePath, int prewarmCount = 0);

	extern IPoolable INodePool.Get();

	extern void INodePool.Free(IPoolable poolable);

	public extern T Get();

	public extern void Free(T obj);
}
