namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class SleepIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public extern SleepIntent();
}
