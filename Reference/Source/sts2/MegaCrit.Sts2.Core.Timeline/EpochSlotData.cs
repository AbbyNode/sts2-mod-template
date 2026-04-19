using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

namespace MegaCrit.Sts2.Core.Timeline;

public class EpochSlotData
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern EpochModel Model
	{
		[CompilerGenerated]
		get;
	}

	public extern EpochSlotState State
	{
		[CompilerGenerated]
		get;
	}

	public extern EpochEra Era
	{
		[CompilerGenerated]
		get;
	}

	public extern int EraPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern EpochSlotData(string modelId, EpochSlotState state);

	public extern EpochSlotData(EpochModel model, EpochSlotState state);
}
