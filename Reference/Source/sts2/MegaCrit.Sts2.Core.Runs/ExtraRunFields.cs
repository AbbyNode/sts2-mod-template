using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class ExtraRunFields
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool StartedWithNeow
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int TestSubjectKills
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool FreedRepy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SerializableExtraRunFields ToSerializable();

	public static extern ExtraRunFields FromSerializable(SerializableExtraRunFields save);

	public extern ExtraRunFields();
}
