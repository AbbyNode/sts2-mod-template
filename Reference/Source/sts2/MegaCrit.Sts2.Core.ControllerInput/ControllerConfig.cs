using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput;

public abstract class ControllerConfig
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected abstract string FolderPath { get; }

	public virtual extern ControllerMappingType ControllerMappingType { get; }

	public virtual extern Dictionary<string, StringName> SteamInputControllerMap { get; }

	public virtual extern Dictionary<StringName, StringName> DefaultControllerInputMap { get; }

	protected virtual extern string FaceButtonNorthGlyph { get; }

	protected virtual extern string FaceButtonSouthGlyph { get; }

	protected virtual extern string FaceButtonEastGlyph { get; }

	protected virtual extern string FaceButtonWestGlyph { get; }

	public extern IEnumerable<string> AssetPaths { get; }

	public static extern IEnumerable<string> AllAssetPaths { get; }

	public extern Texture2D? GetButtonIcon(string button);

	protected extern ControllerConfig();
}
