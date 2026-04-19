using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NEpochPaginateButton.cs")]
public class NEpochPaginateButton : NGoldArrowButton
{
	public new class MethodName : NGoldArrowButton.MethodName
	{
		public extern MethodName();
	}

	public new class PropertyName : NGoldArrowButton.PropertyName
	{
		public new static readonly StringName ClickedSfx;

		public extern PropertyName();
	}

	public new class SignalName : NGoldArrowButton.SignalName
	{
		public extern SignalName();
	}

	protected override extern string ClickedSfx { get; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NEpochPaginateButton();
}
