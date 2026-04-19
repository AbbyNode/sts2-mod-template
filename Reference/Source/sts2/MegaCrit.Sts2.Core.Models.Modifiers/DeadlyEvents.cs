using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class DeadlyEvents : ModifierModel
{
	protected override extern void AfterRunCreated(RunState runState);

	protected override extern void AfterRunLoaded(RunState runState);

	public override extern float ModifyOddsIncreaseForUnrolledRoomType(RoomType roomType, float oddsIncrease);

	public extern DeadlyEvents();
}
