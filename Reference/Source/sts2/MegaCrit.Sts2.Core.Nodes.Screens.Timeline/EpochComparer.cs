using System.Collections.Generic;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

public class EpochComparer : IComparer<SerializableEpoch>
{
	public extern int Compare(SerializableEpoch? x, SerializableEpoch? y);

	public extern EpochComparer();
}
