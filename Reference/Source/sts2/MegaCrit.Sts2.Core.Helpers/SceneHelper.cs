using Godot;

namespace MegaCrit.Sts2.Core.Helpers;

public static class SceneHelper
{
	public static extern string GetScenePath(string innerPath);

	public static extern T Instantiate<T>(string innerPath) where T : Node;
}
