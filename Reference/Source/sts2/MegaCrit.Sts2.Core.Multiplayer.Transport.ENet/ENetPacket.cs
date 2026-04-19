namespace MegaCrit.Sts2.Core.Multiplayer.Transport.ENet;

public class ENetPacket
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ENetPacketType PacketType { get; }

	public extern byte[] AllBytes { get; }

	public extern ENetPacket(byte[] bytes);

	public static extern ENetPacket FromHandshakeRequest(ENetHandshakeRequest request);

	public extern ENetHandshakeRequest AsHandshakeRequest();

	public static extern ENetPacket FromHandshakeResponse(ENetHandshakeResponse response);

	public extern ENetHandshakeResponse AsHandshakeResponse();

	public static extern ENetPacket FromDisconnection(ENetDisconnection disconnection);

	public extern ENetDisconnection AsDisconnection();

	public static extern ENetPacket FromAppMessage(byte[] messageBytes, int count);

	public extern byte[] AsAppMessage();
}
