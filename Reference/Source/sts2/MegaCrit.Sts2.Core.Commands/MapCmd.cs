using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Commands;

public static class MapCmd
{
	public static extern void SetBossEncounter(IRunState runState, EncounterModel boss);
}
