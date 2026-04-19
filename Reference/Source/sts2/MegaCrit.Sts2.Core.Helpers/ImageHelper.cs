using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Helpers;

public static class ImageHelper
{
	public static extern string GetImagePath(string innerPath);

	public static extern string? GetRoomIconPath(MapPointType mapPointType, RoomType roomType, ModelId? modelId);

	public static extern string? GetRoomIconOutlinePath(MapPointType mapPointType, RoomType roomType, ModelId? modelId);
}
