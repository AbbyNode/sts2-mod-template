namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class HealIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public extern HealIntent();
}
