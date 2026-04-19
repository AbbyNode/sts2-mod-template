using System.Collections.Generic;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput;

public class GodotControllerInputStrategy : IControllerInputStrategy
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ControllerConfig? ControllerConfig { get; }

	public extern Dictionary<StringName, StringName> GetDefaultControllerInputMap { get; }

	public extern bool ShouldAllowControllerRebinding { get; }

	public extern Task Init();

	public extern void ProcessInput();

	public extern Texture2D? GetHotkeyIcon(string hotkey);

	public extern GodotControllerInputStrategy();
}
