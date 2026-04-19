using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Nodes.Audio;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes;

[ScriptPath("res://src/Core/Nodes/NRun.cs")]
public class NRun : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public new static readonly StringName _Notification;

		public static readonly StringName SetCurrentRoom;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CombatRoom;

		public static readonly StringName TreasureRoom;

		public static readonly StringName EventRoom;

		public static readonly StringName RestSiteRoom;

		public static readonly StringName MapRoom;

		public static readonly StringName MerchantRoom;

		public static readonly StringName GlobalUi;

		public static readonly StringName RunMusicController;

		public static readonly StringName _cardScene;

		public static readonly StringName _roomContainer;

		public static readonly StringName _testButton;

		public static readonly StringName _seedLabel;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NRun? Instance { get; }

	public extern NCombatRoom? CombatRoom { get; }

	public extern NTreasureRoom? TreasureRoom { get; }

	public extern NEventRoom? EventRoom { get; }

	public extern NRestSiteRoom? RestSiteRoom { get; }

	public extern NMapRoom? MapRoom { get; }

	public extern NMerchantRoom? MerchantRoom { get; }

	public extern NGlobalUi GlobalUi
	{
		[CompilerGenerated]
		get;
	}

	public extern NRunMusicController RunMusicController
	{
		[CompilerGenerated]
		get;
	}

	public extern ScreenStateTracker ScreenStateTracker
	{
		[CompilerGenerated]
		get;
	}

	public static extern NRun Create(RunState state);

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public override extern void _Notification(int what);

	public extern void SetCurrentRoom(Control? node);

	public extern void ShowGameOverScreen(SerializableRun serializableRun);

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

	public extern NRun();
}
