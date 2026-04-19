using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Commands;

public static class ThinkCmd
{
	public static extern void Play(LocString line, Creature speaker, double secondsToDisplay = -1.0);
}
