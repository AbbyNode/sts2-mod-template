using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NCapstoneSubmenuStack.cs")]
public class NCapstoneSubmenuStack : Control, ICapstoneScreen, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName ShowScreen;

		public static readonly StringName GetCapstoneSubmenuType;

		public new static readonly StringName _Ready;

		public static readonly StringName OnSubmenuStackChanged;

		public static readonly StringName AfterCapstoneOpened;

		public static readonly StringName AfterCapstoneClosed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Type;

		public static readonly StringName Stack;

		public static readonly StringName ScreenType;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName DefaultFocusedControl;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern CapstoneSubmenuType Type
	{
		[CompilerGenerated]
		get;
	}

	public extern NRunSubmenuStack Stack
	{
		[CompilerGenerated]
		get;
	}

	public extern NetScreenType ScreenType { get; }

	public extern bool UseSharedBackstop { get; }

	public extern Control? DefaultFocusedControl { get; }

	public extern NSubmenu ShowScreen(CapstoneSubmenuType type);

	public override extern void _Ready();

	public extern void AfterCapstoneOpened();

	public extern void AfterCapstoneClosed();

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

	public extern NCapstoneSubmenuStack();
}
