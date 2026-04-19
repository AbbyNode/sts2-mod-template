using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput;

public class SteamControllerInputStrategy : IControllerInputStrategy
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ControllerConfig? ControllerConfig { get; }

	public extern Dictionary<StringName, StringName> GetDefaultControllerInputMap { get; }

	public extern bool ShouldAllowControllerRebinding { get; }

	[AsyncStateMachine(typeof(_003CInit_003Ed__20))]
	public extern Task Init();

	public extern void ProcessInput();

	public extern Texture2D? GetHotkeyIcon(string hotkey);

	public extern SteamControllerInputStrategy();
}
