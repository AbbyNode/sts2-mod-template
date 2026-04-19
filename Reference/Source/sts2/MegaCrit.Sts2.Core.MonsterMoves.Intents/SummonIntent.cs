namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class SummonIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public extern SummonIntent();
}
