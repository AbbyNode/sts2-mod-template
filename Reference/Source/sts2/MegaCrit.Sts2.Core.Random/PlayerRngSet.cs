using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Random;

public class PlayerRngSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Rng Rewards { get; }

	public extern Rng Shops { get; }

	public extern Rng Transformations { get; }

	public extern uint Seed
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerRngSet(uint seed);

	public extern SerializablePlayerRngSet ToSerializable();

	public static extern PlayerRngSet FromSerializable(SerializablePlayerRngSet save);

	public extern void LoadFromSerializable(SerializablePlayerRngSet save);
}
