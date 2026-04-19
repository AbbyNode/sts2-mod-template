using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public class NetFullCombatState : IPacketSerializable
{
	public struct CreatureState : IPacketSerializable
	{
		public ModelId? monsterId;

		public ulong? playerId;

		public int currentHp;

		public int maxHp;

		public int block;

		public List<PowerState> powers;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);

		public extern CreatureState Anonymized();
	}

	public struct PowerState : IPacketSerializable
	{
		public ModelId id;

		public int amount;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);
	}

	public struct OrbState : IPacketSerializable
	{
		public ModelId id;

		public int passive;

		public int evoke;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);

		public static extern OrbState From(OrbModel orb);
	}

	public struct PlayerState : IPacketSerializable
	{
		public ulong playerId;

		public ModelId characterId;

		public int energy;

		public int stars;

		public int maxStars;

		public int maxPotionCount;

		public int gold;

		public List<CombatPileState> piles;

		public List<PotionState> potions;

		public List<RelicState> relics;

		public List<OrbState> orbs;

		public SerializablePlayerRngSet rngSet;

		public SerializablePlayerOddsSet oddsSet;

		public SerializableRelicGrabBag relicGrabBag;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);

		public extern PlayerState Anonymized();
	}

	public struct CombatPileState : IPacketSerializable
	{
		public PileType pileType;

		public List<CardState> cards;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);

		public static extern CombatPileState From(CardPile pile);
	}

	public struct CardState : IPacketSerializable
	{
		public SerializableCard card;

		public ModelId? affliction;

		public int afflictionCount;

		public List<CardKeyword>? keywords;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);

		public static extern CardState From(CardModel card);
	}

	public struct PotionState : IPacketSerializable
	{
		public ModelId id;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);
	}

	public struct RelicState : IPacketSerializable
	{
		public SerializableRelic relic;

		public extern void Serialize(PacketWriter writer);

		public extern void Deserialize(PacketReader reader);
	}

	public List<uint> nextChoiceIds;

	public uint? lastExecutedHookId;

	public uint? lastExecutedActionId;

	public extern List<CreatureState> Creatures
	{
		[CompilerGenerated]
		get;
	}

	public extern List<PlayerState> Players
	{
		[CompilerGenerated]
		get;
	}

	public extern SerializableRunRngSet Rng
	{
		[CompilerGenerated]
		get;
	}

	public static extern NetFullCombatState FromRun(IRunState runState, GameAction? justFinishedAction);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern NetFullCombatState Anonymized();

	public override extern string ToString();

	public extern NetFullCombatState();
}
