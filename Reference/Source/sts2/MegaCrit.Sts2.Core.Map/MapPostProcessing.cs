namespace MegaCrit.Sts2.Core.Map;

public static class MapPostProcessing
{
	public static extern MapPoint?[,] CenterGrid(MapPoint?[,] grid);

	public static extern MapPoint?[,] StraightenPaths(MapPoint?[,] grid);

	public static extern MapPoint?[,] SpreadAdjacentMapPoints(MapPoint?[,] grid);
}
