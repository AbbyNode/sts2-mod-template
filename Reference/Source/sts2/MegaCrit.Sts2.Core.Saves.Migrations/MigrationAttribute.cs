using System;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Saves.Migrations;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class MigrationAttribute : Attribute
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Type SaveType
	{
		[CompilerGenerated]
		get;
	}

	public extern int FromVersion
	{
		[CompilerGenerated]
		get;
	}

	public extern int ToVersion
	{
		[CompilerGenerated]
		get;
	}

	public extern MigrationAttribute(Type saveType, int fromVersion, int toVersion);
}
