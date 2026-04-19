using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.Settings;

namespace MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Debug/Multiplayer/NMultiplayerTestCharacterPaginator.cs")]
public class NMultiplayerTestCharacterPaginator : NPaginator
{
	public new class MethodName : NPaginator.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnIndexChanged;

		public extern MethodName();
	}

	public new class PropertyName : NPaginator.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NPaginator.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CharacterModel Character { get; }

	public extern event Action<CharacterModel>? CharacterChanged;

	public override extern void _Ready();

	protected override extern void OnIndexChanged(int index);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMultiplayerTestCharacterPaginator();
}
