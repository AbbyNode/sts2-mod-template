using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rewards;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent;

public class CrystalSphereMinigame
{
	public enum CrystalSphereToolType
	{
		None,
		Small,
		Big
	}

	public CrystalSphereCell[,] cells;

	public extern Rng Rng
	{
		[CompilerGenerated]
		get;
	}

	public extern int DivinationCount { get; set; }

	public extern Vector2I GridSize { get; }

	public extern bool IsFinished { get; }

	public extern bool PlacedAllItems
	{
		[CompilerGenerated]
		get;
	}

	public extern CrystalSphereToolType CrystalSphereTool
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<CrystalSphereItem> Items { get; }

	public extern event Action? DivinationCountChanged;

	public extern event Action? Finished;

	public extern CrystalSphereMinigame(Player owner, Rng rng, int divinationCount);

	public extern void ForceMinigameEnd();

	[AsyncStateMachine(typeof(_003CPlayMinigame_003Ed__46))]
	public extern Task PlayMinigame();

	public extern void SetHoveredCell(CrystalSphereCell cell);

	public extern void UnsetHoveredCell();

	public extern void SetTool(CrystalSphereToolType tool);

	[AsyncStateMachine(typeof(_003CCellClicked_003Ed__51))]
	public extern Task CellClicked(CrystalSphereCell clickedCell);

	public extern void AddReward(Reward reward);
}
