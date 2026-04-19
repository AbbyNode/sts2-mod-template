namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class DebuffIntent : AbstractIntent
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public extern DebuffIntent(bool strong = false);
}
