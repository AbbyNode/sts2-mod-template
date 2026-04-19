using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class StatusIntent : AbstractIntent
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IntentType IntentType { get; }

	protected override extern LocString IntentLabelFormat { get; }

	protected override extern string SpritePath { get; }

	protected override extern string IntentPrefix { get; }

	public extern int CardCount
	{
		[CompilerGenerated]
		get;
	}

	public extern StatusIntent(int count);

	public override extern LocString GetIntentLabel(IEnumerable<Creature> _, Creature __);

	protected override extern LocString GetIntentDescription(IEnumerable<Creature> targets, Creature owner);
}
