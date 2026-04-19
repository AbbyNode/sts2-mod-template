using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Map;

public abstract class ActMap
{
	public readonly HashSet<MapPoint> startMapPoints;

	public abstract MapPoint BossMapPoint { get; }

	public abstract MapPoint StartingMapPoint { get; }

	public virtual extern MapPoint? SecondBossMapPoint { get; }

	protected abstract MapPoint?[,] Grid { get; }

	public extern int GetColumnCount();

	public extern int GetRowCount();

	[IteratorStateMachine(typeof(_003CGetAllMapPoints_003Ed__11))]
	public extern IEnumerable<MapPoint> GetAllMapPoints();

	[IteratorStateMachine(typeof(_003CGetPointsInRow_003Ed__12))]
	public extern IEnumerable<MapPoint> GetPointsInRow(int row);

	public virtual extern MapPoint? GetPoint(MapCoord coord);

	protected extern MapPoint? GetPoint(int col, int row);

	public extern bool IsInMap(MapPoint mapPoint);

	public extern bool HasPoint(MapCoord coord);

	protected extern ActMap();
}
