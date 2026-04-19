using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.RichTextTags;

[ScriptPath("res://src/Core/RichTextTags/AbstractMegaRichTextEffect.cs")]
public abstract class AbstractMegaRichTextEffect : RichTextEffect
{
	public new class MethodName : RichTextEffect.MethodName
	{
		public static readonly StringName ShouldTransformText;

		public extern MethodName();
	}

	public new class PropertyName : RichTextEffect.PropertyName
	{
		public static readonly StringName bbcode;

		public static readonly StringName Bbcode;

		public extern PropertyName();
	}

	public new class SignalName : RichTextEffect.SignalName
	{
		public extern SignalName();
	}

	public extern string bbcode { get; }

	protected abstract string Bbcode { get; }

	protected extern bool ShouldTransformText();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	protected extern AbstractMegaRichTextEffect();
}
