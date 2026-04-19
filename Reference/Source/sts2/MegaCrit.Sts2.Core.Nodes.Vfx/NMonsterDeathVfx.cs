using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NMonsterDeathVfx.cs")]
public class NMonsterDeathVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NMonsterDeathVfx? Create(NCreature creatureNode, CancellationToken cancelToken);

	public static extern NMonsterDeathVfx? Create(List<NCreature> creatureNodes);

	[AsyncStateMachine(typeof(_003CPlayVfx_003Ed__15))]
	public extern Task PlayVfx();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMonsterDeathVfx();
}
