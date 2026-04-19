using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Entities.Creatures;

public class DamageResult
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Creature Receiver
	{
		[CompilerGenerated]
		get;
	}

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
	}

	public extern int BlockedDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int UnblockedDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int OverkillDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int TotalDamage { get; }

	public extern bool WasBlockBroken
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool WasFullyBlocked
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool WasTargetKilled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern DamageResult(Creature receiver, ValueProp props);
}
