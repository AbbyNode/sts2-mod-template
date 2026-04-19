using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public class LiftRestSiteOption : RestSiteOption
{
	public override extern LocString Description { get; }

	public override extern string OptionId { get; }

	public extern LiftRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__5))]
	public override extern Task<bool> OnSelect();

	public override extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public override extern Task DoRemotePostSelectVfx();
}
