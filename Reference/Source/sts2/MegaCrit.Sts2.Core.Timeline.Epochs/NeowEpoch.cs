namespace MegaCrit.Sts2.Core.Timeline.Epochs;

public class NeowEpoch : EpochModel
{
	public override extern string Id { get; }

	public override extern EpochEra Era { get; }

	public override extern int EraPosition { get; }

	public override extern string StoryId { get; }

	public override extern bool IsArtPlaceholder { get; }

	public override extern EpochModel[] GetTimelineExpansion();

	public override extern void QueueUnlocks();

	public extern NeowEpoch();
}
