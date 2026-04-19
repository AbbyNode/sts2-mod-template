using Godot;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public static class NetCursorHelper
{
	public static readonly QuantizeParams quantizeParams;

	public static extern Vector2 GetNormalizedPosition(Vector2 mouseScreenPos, Control rootNode);

	public static extern Vector2 GetControlSpacePosition(Vector2 normalizedCursorPosition, Control rootNode);
}
