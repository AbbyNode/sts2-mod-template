namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class HiddenIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string? SpritePath { get; }

	public override extern bool HasIntentTip { get; }

	public extern HiddenIntent();
}
