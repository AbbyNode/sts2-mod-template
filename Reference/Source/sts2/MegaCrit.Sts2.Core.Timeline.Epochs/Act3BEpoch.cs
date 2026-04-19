namespace MegaCrit.Sts2.Core.Timeline.Epochs;

public class Act3BEpoch : EpochModel
{
	public override extern string Id { get; }

	public override extern EpochEra Era { get; }

	public override extern int EraPosition { get; }

	public override extern void QueueUnlocks();

	public extern Act3BEpoch();
}
