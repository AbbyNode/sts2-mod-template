using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect;

[ScriptPath("res://src/Core/Nodes/Screens/CharacterSelect/NCharacterSelectButton.cs")]
public class NCharacterSelectButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName _Process;

		public static readonly StringName LockForAnimation;

		public static readonly StringName Reset;

		public static readonly StringName OnRemotePlayerSelected;

		public static readonly StringName OnRemotePlayerDeselected;

		public static readonly StringName Select;

		public static readonly StringName Deselect;

		public static readonly StringName RefreshState;

		public static readonly StringName GetSaturationForCurrentState;

		public static readonly StringName GetValueForCurrentState;

		public static readonly StringName AnimateSaturationToCurrentState;

		public static readonly StringName RefreshOutline;

		public static readonly StringName RefreshPlayerIcons;

		public static readonly StringName DebugUnlock;

		public static readonly StringName UnlockIfPossible;

		public static readonly StringName UpdateShaderH;

		public static readonly StringName UpdateShaderS;

		public static readonly StringName UpdateShaderV;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsRandom;

		public static readonly StringName IsLocked;

		public static readonly StringName _icon;

		public static readonly StringName _iconAdd;

		public static readonly StringName _lock;

		public static readonly StringName _outlineLocal;

		public static readonly StringName _outlineRemote;

		public static readonly StringName _outlineMixed;

		public static readonly StringName _shadow;

		public static readonly StringName _playerIconContainer;

		public static readonly StringName _hsv;

		public static readonly StringName _isLocked;

		public static readonly StringName _currentOutline;

		public static readonly StringName _isSelected;

		public static readonly StringName _state;

		public static readonly StringName _hoverTween;

		public static readonly StringName _hsvTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern bool IsRandom
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyCollection<ulong> RemoteSelectedPlayers { get; }

	public extern CharacterModel Character { get; }

	public extern bool IsLocked { get; }

	public override extern void _Ready();

	public extern void Init(CharacterModel character, ICharacterSelectButtonDelegate del);

	protected override extern void OnFocus();

	protected override extern void OnPress();

	protected override extern void OnUnfocus();

	public override extern void _Process(double delta);

	public extern void LockForAnimation();

	[AsyncStateMachine(typeof(_003CAnimateUnlock_003Ed__53))]
	public extern Task AnimateUnlock();

	public extern void Reset();

	public extern void OnRemotePlayerSelected(ulong playerId);

	public extern void OnRemotePlayerDeselected(ulong playerId);

	public extern void Select();

	public extern void Deselect();

	public extern void DebugUnlock();

	public extern void UnlockIfPossible();

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

	public extern NCharacterSelectButton();
}
