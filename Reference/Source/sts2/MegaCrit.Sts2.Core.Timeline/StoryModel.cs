namespace MegaCrit.Sts2.Core.Timeline;

public abstract class StoryModel
{
	protected abstract string Id { get; }

	public abstract EpochModel[] Epochs { get; }

	public static extern EpochModel? PrevChapter(EpochModel model);

	public static extern EpochModel? NextChapter(EpochModel model);

	public static extern StoryModel Get(string id);

	protected extern StoryModel();
}
