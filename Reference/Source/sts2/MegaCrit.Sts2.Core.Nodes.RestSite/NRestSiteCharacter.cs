using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;

namespace MegaCrit.Sts2.Core.Nodes.RestSite;

[ScriptPath("res://src/Core/Nodes/RestSite/NRestSiteCharacter.cs")]
public class NRestSiteCharacter : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RandomizeFire;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public static readonly StringName Deselect;

		public static readonly StringName FlipX;

		public static readonly StringName HideFlameGlow;

		public static readonly StringName RefreshThoughtBubbleVfx;

		public static readonly StringName Shake;

		public static readonly StringName GetRestSiteOptionAnchor;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName Hitbox;

		public static readonly StringName _controlRoot;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _leftThoughtAnchor;

		public static readonly StringName _rightThoughtAnchor;

		public static readonly StringName _characterIndex;

		public static readonly StringName _thoughtBubbleVfx;

		public static readonly StringName _selectedOptionConfirmation;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control Hitbox
	{
		[CompilerGenerated]
		get;
	}

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public static extern NRestSiteCharacter Create(Player player, int characterIndex);

	public override extern void _Ready();

	public extern void Deselect();

	public extern void FlipX();

	public extern void HideFlameGlow();

	public extern void ShowHoveredRestSiteOption(RestSiteOption? option);

	public extern void SetSelectingRestSiteOption(RestSiteOption? option);

	public extern void ShowSelectedRestSiteOption(RestSiteOption option);

	public extern void Shake();

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

	public extern NRestSiteCharacter();
}
