using System;

namespace MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

public class ActiveScreenContext
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern ActiveScreenContext Instance { get; }

	public extern event Action? Updated;

	public extern void Update();

	public extern IScreenContext? GetCurrentScreen();

	public extern bool IsCurrent(IScreenContext screen);

	public extern void FocusOnDefaultControl();

	public extern ActiveScreenContext();
}
