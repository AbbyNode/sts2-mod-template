using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public class ScreenStateTracker
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ScreenStateTracker(NMapScreen mapScreen, NCapstoneContainer capstoneContainer, NOverlayStack overlayStack);

	public extern void SetIsInSharedRelicPickingScreen(bool isInSharedRelicPicking);
}
