using System;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent;

public class CrystalSphereCell
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CrystalSphereItem? Item
	{
		[CompilerGenerated]
		get;
	}

	public extern int X
	{
		[CompilerGenerated]
		get;
	}

	public extern int Y
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsHidden { get; set; }

	public extern bool IsHighlighted { get; set; }

	public extern bool IsHovered { get; set; }

	public extern event Action? FogUpdated;

	public extern event Action? HighlightUpdated;

	public extern CrystalSphereCell(int x, int y);

	public extern void SetItem(CrystalSphereItem? item);
}
