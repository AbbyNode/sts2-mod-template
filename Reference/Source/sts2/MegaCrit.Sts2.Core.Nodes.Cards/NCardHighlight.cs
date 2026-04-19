using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Cards;

[ScriptPath("res://src/Core/Nodes/Cards/NCardHighlight.cs")]
public class NCardHighlight : TextureRect
{
	public new class MethodName : TextureRect.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName AnimShow;

		public static readonly StringName AnimHide;

		public static readonly StringName AnimHideInstantly;

		public static readonly StringName AnimFlash;

		public static readonly StringName GetShaderParameter;

		public static readonly StringName SetShaderParameter;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName _curTween;

		public static readonly StringName _shaderMaterial;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public extern SignalName();
	}

	public static readonly Color playableColor;

	public static readonly Color gold;

	public static readonly Color red;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void AnimShow();

	public extern void AnimHide();

	public extern void AnimHideInstantly();

	public extern void AnimFlash();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NCardHighlight();
}
