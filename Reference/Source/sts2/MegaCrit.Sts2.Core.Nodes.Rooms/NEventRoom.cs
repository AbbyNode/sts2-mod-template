using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Events;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NEventRoom.cs")]
public class NEventRoom : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SetPortrait;

		public static readonly StringName DisableOptionButtons;

		public static readonly StringName OnEnteringEventCombat;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Layout;

		public static readonly StringName EmbeddedCombatRoom;

		public static readonly StringName VfxContainer;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _isPreFinished;

		public static readonly StringName _eventContainer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NEventRoom? Instance { get; }

	public extern NEventLayout? Layout { get; }

	public extern ICustomEventNode? CustomEventNode { get; }

	public extern NCombatRoom? EmbeddedCombatRoom { get; }

	public extern Control? VfxContainer
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NEventRoom? Create(EventModel eventModel, IRunState? runState, bool isPreFinished);

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void SetPortrait(Texture2D portrait);

	public extern void OptionButtonClicked(EventOption option, int index);

	public static extern Task Proceed();

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

	public extern NEventRoom();
}
