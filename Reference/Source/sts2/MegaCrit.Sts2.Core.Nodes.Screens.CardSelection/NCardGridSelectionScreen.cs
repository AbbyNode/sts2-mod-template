using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NCardGridSelectionScreen.cs")]
public abstract class NCardGridSelectionScreen : Control, IOverlayScreen, IScreenContext, ICardSelector
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignalsAndInitGrid;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SetPeekButtonTargets;

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

		public static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _grid;

		public static readonly StringName _peekButton;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	protected NCardGrid _grid;

	protected NPeekButton _peekButton;

	protected IReadOnlyList<CardModel> _cards;

	protected readonly TaskCompletionSource<IEnumerable<CardModel>> _completionSource;

	public extern NetScreenType ScreenType { get; }

	protected abstract IEnumerable<Control> PeekButtonTargets { get; }

	public extern bool UseSharedBackstop { get; }

	public virtual extern Control? DefaultFocusedControl { get; }

	public virtual extern Control? FocusedControlFromTopBar { get; }

	public override extern void _Ready();

	protected virtual extern void ConnectSignalsAndInitGrid();

	protected abstract void OnCardClicked(CardModel card);

	[AsyncStateMachine(typeof(_003CCardsSelected_003Ed__11))]
	public extern Task<IEnumerable<CardModel>> CardsSelected();

	public override extern void _ExitTree();

	public virtual extern void AfterOverlayOpened();

	public virtual extern void AfterOverlayClosed();

	public virtual extern void AfterOverlayShown();

	public virtual extern void AfterOverlayHidden();

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

	protected extern NCardGridSelectionScreen();
}
