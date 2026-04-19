using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public sealed class SmithRestSiteOption : RestSiteOption
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string OptionId { get; }

	public override extern IEnumerable<string> AssetPaths { get; }

	public extern int SmithCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern LocString Description { get; }

	public extern SmithRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__12))]
	public override extern Task<bool> OnSelect();

	[AsyncStateMachine(typeof(_003CDoLocalPostSelectVfx_003Ed__13))]
	public override extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public override extern Task DoRemotePostSelectVfx();
}
