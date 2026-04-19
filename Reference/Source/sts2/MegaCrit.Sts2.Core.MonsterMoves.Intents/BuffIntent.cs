namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class BuffIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public extern BuffIntent();
}
