using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Timeline.Epochs;

public class Silent3Epoch : EpochModel
{
	public override extern string Id { get; }

	public override extern EpochEra Era { get; }

	public override extern int EraPosition { get; }

	public override extern string StoryId { get; }

	public static extern List<RelicModel> Relics { get; }

	public override extern string UnlockText { get; }

	public override extern void QueueUnlocks();

	public extern Silent3Epoch();
}
