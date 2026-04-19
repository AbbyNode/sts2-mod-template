using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class QueenBoss : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern IReadOnlyList<string> Slots { get; }

	public override extern string CustomBgm { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public override extern IEnumerable<string>? ExtraAssetPaths { get; }

	public override extern float GetCameraScaling();

	public override extern Vector2 GetCameraOffset();

	public extern QueenBoss();
}
