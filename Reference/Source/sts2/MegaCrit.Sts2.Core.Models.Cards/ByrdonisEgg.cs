using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class ByrdonisEgg : CardModel
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern ByrdonisEgg();

	public override extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);
}
