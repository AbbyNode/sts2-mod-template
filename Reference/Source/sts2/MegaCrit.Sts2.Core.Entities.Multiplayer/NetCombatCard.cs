using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public struct NetCombatCard : IPacketSerializable, IEquatable<NetCombatCard>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public readonly extern uint CombatCardIndex
	{
		[CompilerGenerated]
		get;
	}

	public static extern NetCombatCard ForTesting(uint index);

	public static extern NetCombatCard FromModel(CardModel card);

	public readonly extern CardModel ToCardModel();

	public readonly extern CardModel? ToCardModelOrNull();

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern bool Equals(NetCombatCard other);

	public static extern bool operator ==(NetCombatCard c1, NetCombatCard c2);

	public static extern bool operator !=(NetCombatCard c1, NetCombatCard c2);

	public override extern bool Equals(object? obj);

	public override extern int GetHashCode();

	public override extern string ToString();
}
