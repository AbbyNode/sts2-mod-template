using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NChooseARelicSelection.cs")]
public class NChooseARelicSelection : Control, IOverlayScreen, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SelectHolder;

		public static readonly StringName OnSkipButtonReleased;

		public static readonly StringName AfterOverlayOpened;

		public static readonly StringName AfterOverlayClosed;

		public static readonly StringName AfterOverlayShown;

		public static readonly StringName AfterOverlayHidden;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ScreenType;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _banner;

		public static readonly StringName _relicRow;

		public static readonly StringName _skipButton;

		public static readonly StringName _screenComplete;

		public static readonly StringName _relicSelected;

		public static readonly StringName _cardTween;

		public static readonly StringName _fadeTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetScreenType ScreenType { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern bool UseSharedBackstop { get; }

	public extern Control DefaultFocusedControl { get; }

	public static extern NChooseARelicSelection? ShowScreen(IReadOnlyList<RelicModel> relics);

	public override extern void _Ready();

	public override extern void _ExitTree();

	[AsyncStateMachine(typeof(_003CRelicsSelected_003Ed__20))]
	public extern Task<IEnumerable<RelicModel>> RelicsSelected();

	public extern void AfterOverlayOpened();

	public extern void AfterOverlayClosed();

	public extern void AfterOverlayShown();

	public extern void AfterOverlayHidden();

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

	public extern NChooseARelicSelection();
}
