using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public static class PacketReaderExtensions
{
	public static extern T ReadModel<T>(this PacketReader reader) where T : AbstractModel;

	public static extern ModelId ReadModelIdAssumingType<T>(this PacketReader reader) where T : AbstractModel;

	public static extern ModelId ReadFullModelId(this PacketReader reader);

	public static extern EpochModel ReadEpoch(this PacketReader reader);

	public static extern string ReadEpochId(this PacketReader reader);

	public static extern List<ModelId> ReadFullModelIdList(this PacketReader reader);

	public static extern List<T> ReadModelList<T>(this PacketReader reader) where T : AbstractModel;

	public static extern List<ModelId> ReadModelIdListAssumingType<T>(this PacketReader reader) where T : AbstractModel;
}
