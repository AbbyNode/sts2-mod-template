using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class PhantasmalGardenersElite : EncounterModel
{
	public const string firstSlot = "first";

	public const string secondSlot = "second";

	public const string thirdSlot = "third";

	public const string fourthSlot = "fourth";

	public override extern IReadOnlyList<string> Slots { get; }

	public override extern RoomType RoomType { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public override extern float GetCameraScaling();

	public override extern Vector2 GetCameraOffset();

	public extern PhantasmalGardenersElite();
}
