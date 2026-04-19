using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MegaCrit.Sts2.Core.Models;

public record ModelId : IComparable<ModelId>
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	public extern string Category
	{
		[CompilerGenerated]
		get;
	}

	public extern string Entry
	{
		[CompilerGenerated]
		get;
	}

	public static readonly ModelId none;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ModelId(string category, string entry);

	public static extern ModelId Deserialize(string json);

	public override extern string ToString();

	public extern int CompareTo(ModelId? other);

	public static extern string SlugifyCategory<T>();

	public static extern string SlugifyCategory(string category);

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(ModelId? other);

	[CompilerGenerated]
	protected extern ModelId(ModelId original);
}
