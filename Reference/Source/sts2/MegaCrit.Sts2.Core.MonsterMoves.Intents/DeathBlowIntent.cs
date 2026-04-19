using System;
using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class DeathBlowIntent : SingleAttackIntent
{
	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public override extern IntentType IntentType { get; }

	public override extern Texture2D GetTexture(IEnumerable<Creature> targets, Creature owner);

	public override extern string GetAnimation(IEnumerable<Creature> targets, Creature owner);

	public extern DeathBlowIntent(Func<decimal> damageCalc);
}
