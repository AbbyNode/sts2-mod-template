using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Map;

public class MapPoint : IComparable<MapPoint>
{
	public readonly HashSet<MapPoint> parents;

	public MapCoord coord;

	public extern bool CanBeModified
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern MapPointType PointType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern IReadOnlyList<AbstractModel> Quests { get; }

	public extern HashSet<MapPoint> Children
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action? NodeMarkedChanged;

	public extern int CompareTo(MapPoint? other);

	public extern MapPoint(int col, int row);

	public extern void AddChildPoint(MapPoint child);

	public extern void RemoveChildPoint(MapPoint child);

	public override extern string ToString();

	public extern MapPoint? LeftChild();

	public extern MapPoint? RightChild();

	public extern bool IsAdjacentLeft(MapPoint sibling);

	public extern bool IsAdjacentRight(MapPoint sibling);

	public extern bool IsToTheLeft(MapPoint sibling);

	public extern bool IsToTheRight(MapPoint sibling);

	public extern bool IsInTheSameRow(MapPoint sibling);

	public extern MapPoint? GetFirstCommonDescendant(MapPoint b);

	public extern MapPoint? GetCommonAncestor(MapPoint b);

	public extern int GetLastJunctionLength();

	public extern HashSet<MapPoint> GetAllAncestors();

	public extern IEnumerable<MapPoint> BFS_FindPath(MapPoint target);

	public extern bool IsDescendantPathSame(MapPoint? other);

	public extern void AddQuest(AbstractModel model);

	public extern void RemoveQuest(AbstractModel model);
}
