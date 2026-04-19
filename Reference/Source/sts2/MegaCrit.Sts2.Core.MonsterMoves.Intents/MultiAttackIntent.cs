using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class MultiAttackIntent : AttackIntent
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern LocString IntentLabelFormat { get; }

	public override extern int Repeats { get; }

	public extern MultiAttackIntent(int damage, int repeat);

	public extern MultiAttackIntent(int damage, Func<int> repeatCalc);

	public override extern int GetTotalDamage(IEnumerable<Creature> targets, Creature owner);

	public override extern LocString GetIntentLabel(IEnumerable<Creature> targets, Creature owner);
}
