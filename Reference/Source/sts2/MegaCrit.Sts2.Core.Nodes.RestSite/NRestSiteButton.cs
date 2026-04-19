using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.RestSite;

[ScriptPath("res://src/Core/Nodes/RestSite/NRestSiteButton.cs")]
public class NRestSiteButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Reload;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName RefreshTextState;

		public static readonly StringName UpdateShaderParam;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _hsv;

		public static readonly StringName _visuals;

		public static readonly StringName _icon;

		public static readonly StringName _outline;

		public static readonly StringName _label;

		public static readonly StringName _labelPosition;

		public static readonly StringName _isUnclickable;

		public static readonly StringName _executingOption;

		public static readonly StringName _currentTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern RestSiteOption Option { get; set; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public static extern NRestSiteButton Create(RestSiteOption option);

	protected override extern void OnRelease();

	protected override extern void OnPress();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	public extern void RefreshTextState();

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

	public extern NRestSiteButton();
}
