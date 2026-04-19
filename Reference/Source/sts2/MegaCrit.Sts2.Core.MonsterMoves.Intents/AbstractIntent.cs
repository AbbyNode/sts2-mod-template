using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public abstract class AbstractIntent
{
	protected const string _locTable = "intents";

	protected string? _cachedAnimationName;

	public abstract IntentType IntentType { get; }

	public virtual extern bool HasIntentTip { get; }

	protected virtual extern LocString? IntentLabelFormat { get; }

	protected abstract string IntentPrefix { get; }

	protected abstract string? SpritePath { get; }

	public virtual extern IEnumerable<string> AssetPaths { get; }

	protected extern LocString IntentTitle { get; }

	public virtual extern LocString GetIntentLabel(IEnumerable<Creature> targets, Creature owner);

	public virtual extern Texture2D? GetTexture(IEnumerable<Creature> targets, Creature owner);

	public virtual extern string GetAnimation(IEnumerable<Creature> targets, Creature owner);

	public extern HoverTip GetHoverTip(IEnumerable<Creature> targets, Creature owner);

	protected virtual extern LocString GetIntentDescription(IEnumerable<Creature> targets, Creature owner);

	protected extern AbstractIntent();
}
