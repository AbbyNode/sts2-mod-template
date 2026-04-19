namespace MegaCrit.Sts2.Core.AutoSlay.Helpers;

public class Watchdog
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Watchdog();

	public extern void Reset(string activity);

	public extern void Check();

	public static extern string DumpState();
}
