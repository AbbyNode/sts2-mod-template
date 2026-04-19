using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public abstract class RestSiteOption
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract string OptionId { get; }

	protected extern Player Owner
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString Title { get; }

	public virtual extern LocString Description { get; }

	public extern Texture2D Icon { get; }

	public virtual extern IEnumerable<string> AssetPaths { get; }

	public extern bool IsEnabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected extern RestSiteOption(Player owner);

	public static extern List<RestSiteOption> Generate(Player player);

	public abstract Task<bool> OnSelect();

	public virtual extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public virtual extern Task DoRemotePostSelectVfx();

	public override extern bool Equals(object? obj);

	public override extern int GetHashCode();

	public static extern bool operator ==(RestSiteOption? left, RestSiteOption? right);

	public static extern bool operator !=(RestSiteOption? left, RestSiteOption? right);
}
