using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class SingleAttackIntent : AttackIntent
{
	public override extern int Repeats { get; }

	protected override extern LocString IntentLabelFormat { get; }

	public extern SingleAttackIntent(int damage);

	public extern SingleAttackIntent(Func<decimal> damageCalc);

	public override extern int GetTotalDamage(IEnumerable<Creature> targets, Creature owner);

	public override extern LocString GetIntentLabel(IEnumerable<Creature> targets, Creature owner);
}
