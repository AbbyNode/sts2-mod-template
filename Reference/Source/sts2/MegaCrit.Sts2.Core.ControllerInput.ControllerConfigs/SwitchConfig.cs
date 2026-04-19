namespace MegaCrit.Sts2.Core.ControllerInput.ControllerConfigs;

public class SwitchConfig : ControllerConfig
{
	protected override extern string FolderPath { get; }

	public override extern ControllerMappingType ControllerMappingType { get; }

	protected override extern string FaceButtonSouthGlyph { get; }

	protected override extern string FaceButtonEastGlyph { get; }

	protected override extern string FaceButtonNorthGlyph { get; }

	protected override extern string FaceButtonWestGlyph { get; }

	public extern SwitchConfig();
}
