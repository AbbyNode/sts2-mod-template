using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace MegaCrit.Sts2.Core.Commands;

public static class TalkCmd
{
	public static extern NSpeechBubbleVfx? Play(LocString line, Creature speaker, double secondsToDisplay = -1.0, VfxColor vfxColor = VfxColor.White);
}
