using System.Collections.Generic;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Map;

public static class MapPathPruning
{
	public static extern void PruneDuplicateSegments(MapPoint?[,] grid, HashSet<MapPoint> startMapPoints, MapPoint startingMapPoint, Rng rng);

	public static extern List<List<MapPoint[]>> FindMatchingSegments(MapPoint startingMapPoint);

	public static extern List<List<MapPoint>> FindAllPaths(MapPoint currentMapPoint);
}
