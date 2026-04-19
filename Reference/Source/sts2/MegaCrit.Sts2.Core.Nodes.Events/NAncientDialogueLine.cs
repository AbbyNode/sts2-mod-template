using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Events;

[ScriptPath("res://src/Core/Nodes/Events/NAncientDialogueLine.cs")]
public class NAncientDialogueLine : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnPress;

		public static readonly StringName PlaySfx;

		public static readonly StringName SetAncientAsSpeaker;

		public static readonly StringName SetCharacterAsSpeaker;

		public static readonly StringName SetSpeakerIconVisible;

		public static readonly StringName SetTransparency;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _iconNode;

		public static readonly StringName _tween;

		public static readonly StringName _targetAlpha;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NAncientDialogueLine Create(AncientDialogueLine line, AncientEventModel ancient, CharacterModel character);

	public override extern void _Ready();

	protected override extern void OnUnfocus();

	protected override extern void OnFocus();

	protected override extern void OnPress();

	public extern void PlaySfx();

	public extern void SetSpeakerIconVisible();

	public extern void SetTransparency(float alpha);

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

	public extern NAncientDialogueLine();
}
