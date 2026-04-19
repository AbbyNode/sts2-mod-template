using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Cards.Holders;

[ScriptPath("res://src/Core/Nodes/Cards/Holders/NPreviewCardHolder.cs")]
public class NPreviewCardHolder : NCardHolder
{
	public new class MethodName : NCardHolder.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName Initialize;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName SetCardScale;

		public new static readonly StringName CreateHoverTips;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : NCardHolder.PropertyName
	{
		public new static readonly StringName HoverScale;

		public new static readonly StringName SmallScale;

		public new static readonly StringName IsShowingUpgradedCard;

		public static readonly StringName _showHoverTips;

		public static readonly StringName _scaleOnHover;

		public static readonly StringName _originalScale;

		public extern PropertyName();
	}

	public new class SignalName : NCardHolder.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Vector2 HoverScale { get; }

	public override extern Vector2 SmallScale { get; }

	public override extern bool IsShowingUpgradedCard { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NPreviewCardHolder? Create(NCard card, bool showHoverTips, bool scaleOnHover);

	public override extern void _Ready();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	public extern void SetCardScale(Vector2 scale);

	protected override extern void CreateHoverTips();

	public override extern void _ExitTree();

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

	public extern NPreviewCardHolder();
}
