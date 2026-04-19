using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput.ControllerConfigs;

public class Ps4Config : ControllerConfig
{
	protected override extern string FolderPath { get; }

	public override extern ControllerMappingType ControllerMappingType { get; }

	public override extern Dictionary<string, StringName> SteamInputControllerMap { get; }

	public override extern Dictionary<StringName, StringName> DefaultControllerInputMap { get; }

	public extern Ps4Config();
}
