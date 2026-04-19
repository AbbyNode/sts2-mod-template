using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMapScreen.cs")]
public class NMapScreen : Control, IScreenContext, INetCursorPositionTranslator
{
	[Signal]
	public delegate void OpenedEventHandler();

	[Signal]
	public delegate void ClosedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName GetLineEndpoint;

		public static readonly StringName RecalculateTravelability;

		public static readonly StringName InitMapVotes;

		public static readonly StringName OnMapPointSelectedLocally;

		public static readonly StringName RefreshAllMapPointVotes;

		public static readonly StringName RemoveAllMapPointsAndPaths;

		public new static readonly StringName _Process;

		public static readonly StringName UpdateScrollPosition;

		public new static readonly StringName _GuiInput;

		public static readonly StringName ProcessMouseEvent;

		public static readonly StringName ProcessMouseDrawingEvent;

		public static readonly StringName ProcessScrollEvent;

		public static readonly StringName ProcessControllerEvent;

		public static readonly StringName SetTravelEnabled;

		public static readonly StringName SetDebugTravelEnabled;

		public static readonly StringName RefreshAllPointVisuals;

		public static readonly StringName PlayStartOfActAnimation;

		public static readonly StringName InitMapPrompt;

		public static readonly StringName SetInterruptable;

		public static readonly StringName CanScroll;

		public static readonly StringName TryCancelStartOfActAnim;

		public static readonly StringName OnVisibilityChanged;

		public static readonly StringName OnCapstoneChanged;

		public static readonly StringName Close;

		public static readonly StringName Open;

		public static readonly StringName OnBackButtonPressed;

		public new static readonly StringName _Input;

		public static readonly StringName OnMapDrawingButtonPressed;

		public static readonly StringName OnMapErasingButtonPressed;

		public static readonly StringName UpdateDrawingButtonStates;

		public static readonly StringName OnClearMapDrawingButtonPressed;

		public static readonly StringName HighlightPointType;

		public static readonly StringName OnLegendHotkeyPressed;

		public static readonly StringName OnDrawingToolsHotkeyPressed;

		public static readonly StringName GetNetPositionFromScreenPosition;

		public static readonly StringName GetMapPositionFromNetPosition;

		public static readonly StringName GetScreenPositionFromNetPosition;

		public static readonly StringName IsNodeOnScreen;

		public static readonly StringName CleanUp;

		public static readonly StringName UpdateHotkeyDisplay;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsOpen;

		public static readonly StringName IsTravelEnabled;

		public static readonly StringName IsDebugTravelEnabled;

		public static readonly StringName MapLegendX;

		public static readonly StringName IsTraveling;

		public static readonly StringName Drawings;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _mapContainer;

		public static readonly StringName _pathsContainer;

		public static readonly StringName _points;

		public static readonly StringName _bossPointNode;

		public static readonly StringName _secondBossPointNode;

		public static readonly StringName _startingPointNode;

		public static readonly StringName _mapBgContainer;

		public static readonly StringName _marker;

		public static readonly StringName _backButton;

		public static readonly StringName _drawingToolsHotkeyIcon;

		public static readonly StringName _drawingTools;

		public static readonly StringName _mapDrawingButton;

		public static readonly StringName _mapErasingButton;

		public static readonly StringName _mapClearButton;

		public static readonly StringName _mapLegend;

		public static readonly StringName _legendItems;

		public static readonly StringName _legendHotkeyIcon;

		public static readonly StringName _backstop;

		public static readonly StringName _tween;

		public static readonly StringName _startDragPos;

		public static readonly StringName _targetDragPos;

		public static readonly StringName _isDragging;

		public static readonly StringName _hasPlayedAnimation;

		public static readonly StringName _controllerScrollAmount;

		public static readonly StringName _distX;

		public static readonly StringName _distY;

		public static readonly StringName _actAnimTween;

		public static readonly StringName _mapScrollAnimTimer;

		public static readonly StringName _mapAnimStartDelay;

		public static readonly StringName _mapAnimDuration;

		public static readonly StringName _canInterruptAnim;

		public static readonly StringName _isInputDisabled;

		public static readonly StringName _promptTween;

		public static readonly StringName _drawingInput;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Opened;

		public static readonly StringName Closed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NMapScreen? Instance { get; }

	public extern bool IsOpen
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsTravelEnabled
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsDebugTravelEnabled
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsTraveling
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern Dictionary<Player, MapCoord?> PlayerVoteDictionary
	{
		[CompilerGenerated]
		get;
	}

	public extern NMapDrawings Drawings
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Control DefaultFocusedControl { get; }

	public extern event Action<MapPointType>? PointTypeHighlighted;

	public extern event OpenedEventHandler Opened;

	public extern event ClosedEventHandler Closed;

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void Initialize(RunState runState);

	public extern void SetMap(ActMap map, uint seed, bool clearDrawings);

	public extern void OnMapPointSelectedLocally(NMapPoint point);

	public extern void InitMarker(MapCoord coord);

	[AsyncStateMachine(typeof(_003CTravelToMapCoord_003Ed__94))]
	public extern Task TravelToMapCoord(MapCoord coord);

	public extern void RefreshAllMapPointVotes();

	public override extern void _Process(double delta);

	public override extern void _GuiInput(InputEvent inputEvent);

	public extern void SetTravelEnabled(bool enabled);

	public extern void SetDebugTravelEnabled(bool enabled);

	public extern void RefreshAllPointVisuals();

	public extern void Close(bool animateOut = true);

	public extern NMapScreen Open(bool isOpenedFromTopBar = false);

	public override extern void _Input(InputEvent inputEvent);

	public extern void HighlightPointType(MapPointType pointType);

	public extern void PingMapCoord(MapCoord coord, Player player);

	public extern Vector2 GetNetPositionFromScreenPosition(Vector2 screenPosition);

	public extern Vector2 GetScreenPositionFromNetPosition(Vector2 netPosition);

	public extern bool IsNodeOnScreen(NMapPoint mapPoint);

	public extern void CleanUp();

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

	protected extern void EmitSignalOpened();

	protected extern void EmitSignalClosed();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NMapScreen();
}
