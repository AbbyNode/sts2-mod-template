using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

public class MapSplitVoteAnimation
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern MapSplitVoteAnimation(NMapScreen mapScreen, RunState runState, Dictionary<MapCoord, NMapPoint> mapPointDictionary);

	[AsyncStateMachine(typeof(_003CTryPlay_003Ed__8))]
	public extern Task TryPlay(MapCoord selectedCoord);
}
