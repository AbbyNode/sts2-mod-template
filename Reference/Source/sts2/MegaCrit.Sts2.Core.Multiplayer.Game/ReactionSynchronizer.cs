using System;
using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Reaction;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class ReactionSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern INetGameService NetService
	{
		[CompilerGenerated]
		get;
	}

	public extern ReactionSynchronizer(INetGameService netService, NReactionContainer container);

	public extern void Dispose();

	public extern void SendLocalReaction(ReactionType type, Vector2 mouseScreenPos);
}
