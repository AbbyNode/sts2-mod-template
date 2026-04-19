using Godot;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync;

public class PeerInputMessage : INetMessage, IPacketSerializable
{
	public bool mouseDown;

	public bool isTargeting;

	public Vector2? netMousePos;

	public NetScreenType screenType;

	public HoveredModelData hoveredModelData;

	public bool isUsingController;

	public Vector2? controllerFocusPosition;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern PeerInputMessage();
}
