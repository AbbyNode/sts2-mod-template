namespace MegaCrit.Sts2.Core.Saves;

public class StaticProfileIdProvider : IProfileIdProvider
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int CurrentProfileId { get; }

	public extern StaticProfileIdProvider(int profileId);
}
