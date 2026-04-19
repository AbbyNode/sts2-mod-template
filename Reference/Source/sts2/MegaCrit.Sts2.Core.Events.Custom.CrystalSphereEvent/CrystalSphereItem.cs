using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent;

public abstract class CrystalSphereItem
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract Vector2I Size { get; }

	public extern Vector2I Position
	{
		[CompilerGenerated]
		get;
	}

	protected virtual extern string TexturePath { get; }

	public extern Texture2D Texture { get; }

	public abstract bool IsGood { get; }

	public extern event Action<CrystalSphereItem>? Revealed;

	public extern bool PlaceItem(CrystalSphereMinigame game);

	public virtual extern Task RevealItem(Player _);

	protected extern CrystalSphereItem();
}
