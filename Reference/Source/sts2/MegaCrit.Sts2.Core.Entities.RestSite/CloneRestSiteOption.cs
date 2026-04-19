using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public class CloneRestSiteOption : RestSiteOption
{
	public override extern string OptionId { get; }

	public override extern LocString Description { get; }

	public extern CloneRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__5))]
	public override extern Task<bool> OnSelect();

	public override extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public override extern Task DoRemotePostSelectVfx();
}
