using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/Utilities/LocalizedTexture.cs")]
public class LocalizedTexture : Resource
{
	public new class MethodName : Resource.MethodName
	{
		public extern MethodName();
	}

	public new class PropertyName : Resource.PropertyName
	{
		public static readonly StringName _textures;

		public extern PropertyName();
	}

	public new class SignalName : Resource.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool TryGetTexture(out Texture2D? texture);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern LocalizedTexture();
}
