using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Rngs;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class RunRngSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string StringSeed
	{
		[CompilerGenerated]
		get;
	}

	public extern uint Seed
	{
		[CompilerGenerated]
		get;
	}

	public extern Rng UpFront { get; }

	public extern Rng Shuffle { get; }

	public extern Rng UnknownMapPoint { get; }

	public extern Rng CombatCardGeneration { get; }

	public extern Rng CombatPotionGeneration { get; }

	public extern Rng CombatCardSelection { get; }

	public extern Rng CombatEnergyCosts { get; }

	public extern Rng CombatTargets { get; }

	public extern Rng MonsterAi { get; }

	public extern Rng Niche { get; }

	public extern Rng CombatOrbGeneration { get; }

	public extern Rng TreasureRoomRelics { get; }

	public static extern RunRngSet GetMockInstance();

	public extern RunRngSet(string seed);

	public extern SerializableRunRngSet ToSerializable();

	public static extern RunRngSet FromSave(SerializableRunRngSet save);

	public extern void LoadFromSerializable(SerializableRunRngSet save);

	public extern void MockRng(RunRngType rngType, uint seed);
}
