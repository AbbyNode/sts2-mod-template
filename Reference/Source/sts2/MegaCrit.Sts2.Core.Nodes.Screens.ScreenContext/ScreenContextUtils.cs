using Godot;

namespace MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

public static class ScreenContextUtils
{
	public static extern void UpdateControllerNavEnabled<T>(this T screenContext) where T : Control, IScreenContext;
}
