using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class EventSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<EventModel> Events { get; }

	public extern bool IsShared { get; }

	public extern event Action<Player>? PlayerVoteChanged;

	public extern EventSynchronizer(RunLocationTargetedMessageBuffer messageBuffer, INetGameService netService, IPlayerCollection playerCollection, ulong localPlayerId, uint seed);

	public extern void Dispose();

	public extern void BeginEvent(EventModel canonicalEvent, bool isPrefinished = false, Action<EventModel>? debugOnStart = null);

	public extern void ChooseLocalOption(int index);

	public extern uint? GetPlayerVote(Player player);

	public extern EventModel GetLocalEvent();

	public extern EventModel GetEventForPlayer(Player player);

	public extern void ResumeEvents(AbstractRoom exitedRoom);
}
