using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Events;

[ScriptPath("res://src/Core/Nodes/Events/NEventOptionButton.cs")]
public class NEventOptionButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetVisuallyLocked;

		public static readonly StringName AnimateIn;

		public static readonly StringName EnableButton;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName GrayOut;

		public static readonly StringName UpdateShaderParam;

		public static readonly StringName RefreshVotes;

		public new static readonly StringName _ExitTree;

		public static readonly StringName WillKillPlayer;

		public static readonly StringName ShowPersistentKillGlow;

		public static readonly StringName PulseKillGlow;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName Index;

		public static readonly StringName VoteContainer;

		public static readonly StringName _label;

		public static readonly StringName _image;

		public static readonly StringName _outline;

		public static readonly StringName _killGlow;

		public static readonly StringName _confirmFlash;

		public static readonly StringName _hsv;

		public static readonly StringName _playerVoteContainer;

		public static readonly StringName _animInTween;

		public static readonly StringName _flashTween;

		public static readonly StringName _killGlowTween;

		public static readonly StringName _tween;

		public static readonly StringName _buttonColor;

		public static readonly StringName _deathPreventionVfx;

		public static readonly StringName _deathPreventionVfxPosition;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern EventModel Event
	{
		[CompilerGenerated]
		get;
	}

	public extern EventOption Option
	{
		[CompilerGenerated]
		get;
	}

	public extern NMultiplayerVoteContainer VoteContainer { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NEventOptionButton Create(EventModel eventModel, EventOption option, int index);

	public override extern void _Ready();

	public extern void AnimateIn();

	public extern void EnableButton();

	protected override extern void OnRelease();

	protected override extern void OnPress();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	[AsyncStateMachine(typeof(_003CFlashConfirmation_003Ed__55))]
	public extern Task FlashConfirmation();

	public extern void GrayOut();

	public extern void RefreshVotes();

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

	public extern NEventOptionButton();
}
