using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public abstract class AttackIntent : AbstractIntent
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	public extern Func<decimal>? DamageCalc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public virtual extern int Repeats { get; }

	protected override extern string SpritePath { get; }

	public override extern IEnumerable<string> AssetPaths { get; }

	public override extern Texture2D GetTexture(IEnumerable<Creature> targets, Creature owner);

	public override extern string GetAnimation(IEnumerable<Creature> targets, Creature owner);

	protected override extern LocString GetIntentDescription(IEnumerable<Creature> targets, Creature owner);

	public abstract int GetTotalDamage(IEnumerable<Creature> targets, Creature owner);

	public extern int GetSingleDamage(IEnumerable<Creature> targets, Creature owner);

	protected extern AttackIntent();
}
