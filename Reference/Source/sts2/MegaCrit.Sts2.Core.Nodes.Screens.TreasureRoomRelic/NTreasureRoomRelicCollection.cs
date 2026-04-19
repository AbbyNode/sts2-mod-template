using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic;

[ScriptPath("res://src/Core/Nodes/Screens/TreasureRoomRelic/NTreasureRoomRelicCollection.cs")]
public class NTreasureRoomRelicCollection : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName InitializeRelics;

		public static readonly StringName SetSelectionEnabled;

		public static readonly StringName AnimIn;

		public static readonly StringName AnimOut;

		public static readonly StringName PickRelic;

		public static readonly StringName RefreshVotes;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName SingleplayerRelicHolder;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _fightBackstop;

		public static readonly StringName _hands;

		public static readonly StringName _openedTicks;

		public static readonly StringName _emptyLabel;

		public static readonly StringName _isEmptyChest;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NTreasureRoomRelicHolder SingleplayerRelicHolder
	{
		[CompilerGenerated]
		get;
	}

	public extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void Initialize(IRunState runState);

	public extern void InitializeRelics();

	public extern void SetSelectionEnabled(bool isEnabled);

	public extern Task RelicPickingFinished();

	public extern void AnimIn(Node chestVisual);

	public extern void AnimOut(Node chestVisual);

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

	public extern NTreasureRoomRelicCollection();
}
