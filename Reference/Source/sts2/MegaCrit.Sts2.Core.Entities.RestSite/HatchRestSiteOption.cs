using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public class HatchRestSiteOption : RestSiteOption
{
	public override extern string OptionId { get; }

	public extern HatchRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__3))]
	public override extern Task<bool> OnSelect();

	public override extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public override extern Task DoRemotePostSelectVfx();
}
