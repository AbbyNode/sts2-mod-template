using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models.Acts;

public sealed class Hive : ActModel
{
	public override extern string ChestOpenSfx { get; }

	public override extern IEnumerable<EncounterModel> BossDiscoveryOrder { get; }

	public override extern IEnumerable<AncientEventModel> AllAncients { get; }

	public override extern IEnumerable<EventModel> AllEvents { get; }

	public override extern string[] BgMusicOptions { get; }

	public override extern string[] MusicBankPaths { get; }

	public override extern string AmbientSfx { get; }

	public override extern string ChestSpineResourcePath { get; }

	public override extern string ChestSpineSkinNameNormal { get; }

	public override extern string ChestSpineSkinNameStroke { get; }

	public override extern Color MapTraveledColor { get; }

	public override extern Color MapUntraveledColor { get; }

	public override extern Color MapBgColor { get; }

	public override extern IEnumerable<EncounterModel> GenerateAllEncounters();

	public override extern IEnumerable<AncientEventModel> GetUnlockedAncients(UnlockState unlockState);

	public override extern MapPointTypeCounts GetMapPointTypes(Rng mapRng);

	public extern Hive();
}
