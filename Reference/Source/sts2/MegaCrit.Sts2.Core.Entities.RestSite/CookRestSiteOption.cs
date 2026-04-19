using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public sealed class CookRestSiteOption : RestSiteOption
{
	public override extern string OptionId { get; }

	public override extern LocString Description { get; }

	public extern CookRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__7))]
	public override extern Task<bool> OnSelect();
}
