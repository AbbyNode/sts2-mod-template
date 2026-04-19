using System;
using System.Runtime.CompilerServices;

namespace BaseLib.Utils;

/// <summary>
/// A basic wrapper around <seealso cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> for convenience.
/// While this can be used to store value types, they will be boxed and thus is somewhat inefficient.
/// </summary>
/// <typeparam name="TKey"></typeparam>
/// <typeparam name="TVal"></typeparam>
public class SpireField<TKey, TVal> where TKey : class
{
	private readonly ConditionalWeakTable<TKey, object?> _table = new ConditionalWeakTable<TKey, object>();

	private readonly Func<TKey, TVal?> _defaultVal;

	public TVal? this[TKey obj]
	{
		get
		{
			return Get(obj);
		}
		set
		{
			Set(obj, value);
		}
	}

	public SpireField(Func<TVal?> defaultVal)
	{
		_defaultVal = (TKey _) => defaultVal();
	}

	public SpireField(Func<TKey, TVal?> defaultVal)
	{
		_defaultVal = defaultVal;
	}

	public TVal? Get(TKey obj)
	{
		if (_table.TryGetValue(obj, out object value))
		{
			return (TVal)value;
		}
		_table.Add(obj, value = _defaultVal(obj));
		return (TVal)value;
	}

	public void Set(TKey obj, TVal? val)
	{
		_table.AddOrUpdate(obj, val);
	}
}
