using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class DramaticEntrance : CardModel
{
	public const string vfxPath = "vfx/vfx_dramatic_entrance_fullscreen";

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern DramaticEntrance();
}
