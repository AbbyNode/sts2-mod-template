using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen;

[ScriptPath("res://src/Core/Nodes/Screens/GameOverScreen/NRunSummary.cs")]
public class NRunSummary : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _badgeContainer;

		public static readonly StringName _discoveryContainer;

		public static readonly StringName _discoveryHeader;

		public static readonly StringName _discoveredCards;

		public static readonly StringName _discoveredRelics;

		public static readonly StringName _discoveredPotions;

		public static readonly StringName _discoveredEnemies;

		public static readonly StringName _discoveredEpochs;

		public static readonly StringName _cardCount;

		public static readonly StringName _relicCount;

		public static readonly StringName _potionCount;

		public static readonly StringName _enemyCount;

		public static readonly StringName _epochCount;

		public static readonly StringName _tween;

		public static readonly StringName _waitTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003CAnimateInDiscoveries_003Ed__16))]
	public extern Task AnimateInDiscoveries(RunState runState);

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

	public extern NRunSummary();
}
