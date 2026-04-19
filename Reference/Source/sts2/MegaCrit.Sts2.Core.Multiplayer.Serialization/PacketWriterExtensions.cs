using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public static class PacketWriterExtensions
{
	public static extern void WriteModel<T>(this PacketWriter writer, T model) where T : AbstractModel;

	public static extern void WriteModelEntry(this PacketWriter writer, ModelId id);

	public static extern void WriteEpoch<T>(this PacketWriter writer) where T : EpochModel;

	public static extern void WriteEpoch(this PacketWriter writer, EpochModel epochModel);

	public static extern void WriteEpochId(this PacketWriter writer, string epochId);

	public static extern void WriteFullModelId(this PacketWriter writer, ModelId id);

	public static extern void WriteFullModelIdList(this PacketWriter writer, IReadOnlyCollection<ModelId> models);

	public static extern void WriteModelList<T>(this PacketWriter writer, IReadOnlyCollection<T> models) where T : AbstractModel;

	public static extern void WriteModelEntriesInList(this PacketWriter writer, IReadOnlyCollection<ModelId> modelIds);
}
