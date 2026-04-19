using MegaCrit.Sts2.Core.HoverTips;

namespace MegaCrit.Sts2.Core.MonsterMoves.Intents;

public class StunIntent : AbstractIntent
{
	public override extern IntentType IntentType { get; }

	protected override extern string IntentPrefix { get; }

	protected override extern string SpritePath { get; }

	public static extern HoverTip GetStaticHoverTip();

	public extern StunIntent();
}
