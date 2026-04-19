using System;
using Godot;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public class PeerInputSynchronizer : IDisposable
{
	public const int minUpdateMsec = 50;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern INetGameService NetService { get; }

	public extern event Action<ulong>? StateAdded;

	public extern event Action<ulong>? StateRemoved;

	public extern event Action<ulong>? StateChanged;

	public extern event Action<ulong, NetScreenType>? ScreenChanged;

	public extern PeerInputSynchronizer(INetGameService netService);

	public extern void Dispose();

	public extern void SyncLocalMousePos(Vector2 mouseScreenPos, Control rootControl);

	public extern void SyncLocalControllerFocus(Vector2 focusPosition, Control rootControl);

	public extern void SyncLocalIsUsingController(bool isUsingController);

	public extern void SyncLocalMouseDown(bool mouseDown);

	public extern void SyncLocalScreen(NetScreenType netScreenType);

	public extern void SyncLocalHoveredModel(AbstractModel? model);

	public extern void SyncLocalIsTargeting(bool isTargeting);

	public extern void StartOverridingCursorPositioning(INetCursorPositionTranslator positionTranslator);

	public extern void StopOverridingCursorPositioning();

	public extern Vector2 GetControlSpaceFocusPosition(ulong playerId, Control rootControl);

	public extern bool GetMouseDown(ulong playerId);

	public extern NetScreenType GetScreenType(ulong playerId);

	public extern HoveredModelData GetHoveredModelData(ulong playerId);

	public extern bool GetIsTargeting(ulong playerId);

	public extern void OnPlayerDisconnected(ulong playerId);
}
