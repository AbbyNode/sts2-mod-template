using MegaCrit.Sts2.Core.HoverTips;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class TinkerTime : EventModel
{
	public enum RiderEffect
	{
		None,
		Sapping,
		Violence,
		Choking,
		Energized,
		Wisdom,
		Chaos,
		Expertise,
		Curious,
		Improvement
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IHoverTip[] GetRiderHoverTips(RiderEffect rider);

	public extern TinkerTime();
}
