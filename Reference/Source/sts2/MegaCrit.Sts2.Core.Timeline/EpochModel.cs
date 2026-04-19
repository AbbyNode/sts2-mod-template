using System;
using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Timeline;

public abstract class EpochModel
{
	public static extern IReadOnlyList<string> AllEpochIds { get; }

	public extern string Year { get; }

	public extern string EraName { get; }

	public abstract string Id { get; }

	public extern ModelId ModelId { get; }

	public virtual extern bool IsArtPlaceholder { get; }

	public extern LocString Title { get; }

	public extern string Description { get; }

	public extern string? StoryTitle { get; }

	public virtual extern string? StoryId { get; }

	public extern LocString UnlockInfo { get; }

	public virtual extern string UnlockText { get; }

	public abstract EpochEra Era { get; }

	public abstract int EraPosition { get; }

	public extern Texture2D Portrait { get; }

	public extern string PackedPortraitPath { get; }

	public extern Texture2D BigPortrait { get; }

	public extern string BigPortraitPath { get; }

	public extern int ChapterIndex { get; }

	public virtual extern EpochModel[] GetTimelineExpansion();

	public virtual extern void QueueUnlocks();

	public static extern string GetId<T>() where T : EpochModel;

	public static extern string GetId(Type t);

	public static extern bool IsValid(string id);

	public static extern EpochModel Get(string id);

	public static extern EpochModel Get<T>() where T : EpochModel;

	protected static extern void QueueTimelineExpansion(EpochModel[] epochs);

	protected extern string CreateCardUnlockText(List<CardModel> cards);

	protected extern string CreateRelicUnlockText(List<RelicModel> relics);

	protected extern string CreatePotionUnlockText(List<PotionModel> potions);

	protected extern EpochModel();
}
